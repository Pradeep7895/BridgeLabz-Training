using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.scenario_based.parcel_tracker
{
    internal class ParcelUtility : IParcel
    {
        //head node
        private StageNode head;
        //to represent the current order
        private Order CurrentOrder;

        //method to add order 
        public void AddOrder()
        {
            Console.WriteLine("Enter Order Id: ");
            int id = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Customer Name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Address: ");
            string address = Console.ReadLine();

            Console.WriteLine("Enter Phone number : ");
            string number = Console.ReadLine();
            
            CurrentOrder = new Order(id, name, address, number);
            head = null;
            Console.WriteLine("Order added Successfully.");

        }

        //method to add stage 
        public void AddStage()
        {
            //if there is no order booked
            if(CurrentOrder == null)
            {
                Console.WriteLine("Add an order first");
                return;
            }
            //delivery stage
            Console.WriteLine("Enter delivery stage: ");
            string stage = Console.ReadLine();

            //newnode 
            StageNode newNode = new StageNode(stage);

            if(head == null)
            {
                head = newNode;
                return;
            }
            //traverse the list to add the stage at the stage at last
            StageNode temp = head;
            while(temp.Next != null)
            {
                temp = temp.Next;
            }
            temp.Next = newNode;
        }

        //method to add intermediate stage
        public void AddIntermediateStage()
        {
            //if head is null, no stages availbale
            if(head == null)
            {
                Console.WriteLine("No stage available");
                return;
            }
            //enter the existing node after which the newNode should be added
            Console.WriteLine("Enter existing stage: ");
            string existingStage = Console.ReadLine();

            //new stage to be added
            Console.WriteLine("Enter new stage:");
            string newStage = Console.ReadLine();

            StageNode temp = head;

            //traverse till until, temp is not equal to null and stage name is not equal to existing stage
            while(temp != null && temp.StageName != existingStage)
            {
                temp = temp.Next;
            }
            if(temp == null)
            {
                Console.WriteLine("No stage found");
                return;
            }
            //newNode to be added
            StageNode newNode = new StageNode(newStage);
            //pass the temp.Next and newNode.Next to the same reference 
            //means temp.Next --> a
            // and newNode.temp --> a
            newNode.Next = temp.Next;

            //pass the temp.Next reference to newNode node
            //meand temp.Next --> newNode
            temp.Next = newNode;
            Console.WriteLine("Intermediate stage added.");
        }
        //method to track stage of parcel
        public void TrackParcel()
        {
            if(CurrentOrder == null)
            {
                Console.WriteLine("No order Available.");
                return;
            }
            //Display the details
            CurrentOrder.DisplayDetails();

            Console.WriteLine("Track Parcel: ");
            StageNode temp = head;
            while(temp != null)
            {
                Console.Write(temp.StageName + "-->");
                temp = temp.Next;
            }
            Console.WriteLine("END");
        }
        //handle lost parcel 
        public void LostParcel()
        {
            if(CurrentOrder == null)
            {
                Console.WriteLine("No order to mark lost");
                return;
            }
            //make head to null, to empty the list of stage 
            head = null;
            Console.WriteLine("Parcel traking lost");
        }
    }
}
