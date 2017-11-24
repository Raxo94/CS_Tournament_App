using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication2;
using System.Web.UI.WebControls;


namespace Turnament_NameSpace
{
    public class Player
    {
        public string name;
        public int age;
        public Player(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }

    public class Turnament
    {
        public string name;
        public Turnament parent;
        public int depth;
        public List<Player> players;
        public List<Turnament> subTurnaments;


        public Turnament(int depth, string name)
        {
            this.depth = depth;
            this.name = name;
            this.parent = null;
            players = new List<Player>();
            subTurnaments = new List<Turnament>();
        }
        public Turnament(int depth, string name, Turnament parent)
        {
            this.depth = depth;
            this.name = name;
            this.parent = parent;
            players = new List<Player>();
            subTurnaments = new List<Turnament>();
        }
        public void WriteSubTurnamentsToList(ListBox lBox)
        {
            foreach (Turnament t in subTurnaments)
            {
                string emptySpace = "";
                for (int i = 0; i < t.depth; i++)
                {
                    emptySpace += "--";
                }
                string showcaseName = emptySpace + t.name;
                lBox.Items.Add(showcaseName);
                t.WriteSubTurnamentsToList(lBox);
            }
        }
        public Turnament FindSubTurnament(string name)
        {
            Turnament result = null;
            foreach (Turnament t in subTurnaments)
            {
                if(name == t.name)
                {
                    return t;
                }
                else
                {
                    result = t.FindSubTurnament(name);
                    if(result != null)
                    {
                        return result;
                    }
                }
            }
            return result;
        }

        public void AddPlayer(Player newPlayer)
        {
            foreach(Player p in players)
            {
                if (p.name == newPlayer.name)
                {
                    return;
                }
                
            }
            players.Add(newPlayer);
            if(parent != null)
            {
                parent.AddPlayer(newPlayer);
            }

        }
        public void RemovePlayer(Player removePlayer)
        {
            players.Remove(removePlayer);
            foreach(Turnament t in subTurnaments)
            {
                t.RemovePlayer(removePlayer);
            }
        }


        public void ShowPlayersInTurnament(ListBox lBox)
        {
            lBox.Items.Clear();
            foreach(Player p in players)
            {
                lBox.Items.Add(p.name + ", " + p.age);
            }
        }
        public void Clear()
        {
            foreach(Turnament t in subTurnaments)
            {
                t.Clear();
            }
            subTurnaments.Clear();
        }

        public void ClearSpecific(string name)
        {
            foreach (Turnament t in subTurnaments)
            {
                if (t.name == name)
                {
                    t.Clear();
                    subTurnaments.Remove(t);
                    return;
                }
                else
                {
                    t.ClearSpecific(name);
                }

            }

        }
    }


    public static class TurnamentHandler
    {
        public static List<Turnament> turnaments = new List<Turnament>();
        public static List<Player> Players = new List<Player>();

        public static void ViewTurnaments(ListBox lBox)
        {
            lBox.Items.Clear();
            

            foreach (Turnament t in turnaments)
            {
                lBox.Items.Add(t.name);
                t.WriteSubTurnamentsToList(lBox);
                
            }
        }
        public static Turnament FindTurnament(string name)
        {
            foreach (Turnament t in turnaments)
            {
                if (name == t.name)
                {
                    return t;
                }
                else
                {
                    Turnament result = t.FindSubTurnament(name);
                    if (result != null)
                    {
                        return result;
                    }
                }
            }
            //if not found
            return null;
        }
        public static bool IsNameFine(string name)
        {
            if( name != "")
            {
                
                if(FindTurnament(name) == null)
                {
                    return true;
                }
            } 
            return false;
        }
        public static void ClearTurnaments()
        {
            foreach(Turnament t in turnaments)
            {
                t.Clear();
            }
            turnaments.Clear();

        }

        public static void ClearSpecific(string name)
        {
            foreach (Turnament t in turnaments)
            {
                if (t.name == name)
                {
                    t.Clear();
                    turnaments.Remove(t);
                    return;
                }
                else
                {
                    t.ClearSpecific(name);
                }

            }
            
        }
        public static void ViewPlayers(ListBox lBox)
        {
            lBox.Items.Clear();
            foreach (Player p in Players)
            {
                lBox.Items.Add(p.name + ", " + p.age);
            }
        }
        public static bool IsPlayerNameFine(string name)
        {
            if (name != "")
            {
                foreach(Player p in Players)
                {
                    if (p.name == name)
                    {
                        return false;
                    }
                }
                return true;
            }
            return false;
        }
        public static bool IsPlayerNameFine(string name, string exception)
        {
            if (name != "")
            {
                foreach (Player p in Players)
                {
                    if (p.name == name && name!= exception)
                    {
                        return false;
                    }
                }
                return true;
            }
            return false;
        }

        public static Player FindPlayer(string name)
        {
            foreach(Player p in Players)
            {
                if (name == p.name)
                {
                    return p;
                }
            }
            return null;
        }
        public static void DeletePlayer(string name)
        {
            foreach (Player p in Players)
            {
                if (name == p.name)
                {
                    Players.Remove(p);
                }
            }
            
        }
    };
}
