using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject
{
    public enum Status
    {
        empty,          //stuck, can't add packages from belt
        emptybase,
        small,          //small
        smallWrapped,
        medium,
        tall,           //stuck
        bustedSmall,    //stuck
        bustedTall,     //stuck
        closed,         //stuck
        needswrap,      //for staging
        readytomove     //for staging
    }
    internal class Pallet
    {
        public bool stuck //if all pallets are stuck for too long, lose a life
        {
            get
            {
                if (status == Status.empty || status == Status.small || status == Status.tall || status == Status.bustedSmall || status == Status.bustedTall || status == Status.closed)
                {
                    return stuck = true;
                }
                else
                {
                    return stuck = false;
                }
            }
            set { }
        }
        public int location { get; set; }
        public Status status { get; set; }
        public Pallet(int location, Status status) //for staging pallets that don't need stuck or not stuck
        {
            this.location = location;
            this.status = status;
        }
    }
    [Serializable()]
    public class Player : IComparable<Player>
    {
        public string name { get; set; }
        public int score { get; set; }
        public Player(string name, int score)
        {
            this.name = name;
            this.score = score;
        }
        public Player() { }
        public int CompareTo(Player other)
        {
            return other.score.CompareTo(score);
        }
    }
}
