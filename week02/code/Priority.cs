public static class Priority {
    public static void Test() {
        // TODO Problem 2 - Write and run test cases and fix the code to match requirements
        // Example of creating and using the priority queue
        var priorityQueue = new PriorityQueue();
        Console.WriteLine(priorityQueue);

        // Test Cases

        // Test 1
        // Scenario: Create a queue with following people and priority Bob (4), Tim (2), and Sue (1), George (3)
        // remove the highest priority and printing it out.
        // Expected Result: Sue, George, Time, Bob
        Console.WriteLine("Test 1");
        priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Bob", 1);
        priorityQueue.Enqueue("Tim", 2);
        priorityQueue.Enqueue("Sue", 4);
        priorityQueue.Enqueue("George", 3);
        Console.WriteLine(priorityQueue);
        for (int i = 0; i < 5; i++) {
            Console.WriteLine($"{priorityQueue.Dequeue()}");
        }
        Console.WriteLine(priorityQueue);
        

        // Defect(s) Found: 
        //found highest priority but didn't remove it from the list.
        //added function to remove highest priority to the Dequeue function. 

        Console.WriteLine("---------");

        // Test 2
        // Scenario: Create a queue with following people and priority Bob (1), Tim (2), and Sue (4), George (3), John (4), Paul (2)
        //multiple cases with the same priority remove highest priority and closest to the front of the line
        // Expected Result: Sue, John, George, Tim, Paul, Bob
        Console.WriteLine("Test 2");
        priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Bob", 1);
        priorityQueue.Enqueue("Tim", 2);
        priorityQueue.Enqueue("Sue", 4);
        priorityQueue.Enqueue("George", 3);
        priorityQueue.Enqueue("John", 4);
        priorityQueue.Enqueue("Paul", 2);
        Console.WriteLine(priorityQueue);
        for (int i = 0; i < 7; i++) {
            Console.WriteLine($"{priorityQueue.Dequeue()}");
        }
        Console.WriteLine(priorityQueue);


        // Defect(s) Found: 
        //found highest priority but didn't remove it from the list, and didn't choose the one closest to index 0. made some updates to the dequeue function so it would select the highest priority with the smalles index.
        //added function to remove highest priority to the Dequeue function. 

        Console.WriteLine("---------");

        // Add more Test Cases As Needed Below

        // Test 3
        // Scenario: Try to get the next person from an empty queue
        // Expected Result: Error message should be displayed
        Console.WriteLine("Test 3");
        priorityQueue = new PriorityQueue();
        Console.WriteLine(priorityQueue);
        Console.WriteLine($"{priorityQueue.Dequeue()}");
        Console.WriteLine(priorityQueue);

        // Defect(s) Found: 
        //This test worked

        Console.WriteLine("---------");

    }
}