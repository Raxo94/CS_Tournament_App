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
        public string parentName;
        public int depth;
        public List<Player> participants;
        public List<Turnament> subTurnaments;


        public Turnament(int depth, string name)
        {
            this.depth = depth;
            this.name = name;
            participants = new List<Player>();
            subTurnaments = new List<Turnament>();
        }
        public Turnament(int depth, string name, string parentName)
        {
            this.depth = depth;
            this.name = name;
            this.parentName = parentName;
            participants = new List<Player>();
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
        public void Clear()
        {
            foreach(Turnament t in subTurnaments)
            {
                t.Clear();
            }
            subTurnaments.Clear();
        } 
    }


    public static class TurnamentHandler
    {
        public static int five = 6;
        public static List<Turnament> turnaments = new List<Turnament>();


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
    };
}
