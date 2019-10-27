using System;

namespace _2_ControlFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Control flow.

                We're playing with if / else.

                if statements are built like this:

                if(<boolean-expression>){
                    <all your statements you want to execute if your boolean expression equals true.>
                }

                Scroll on down until I say stop
                 
             */
            Console.WriteLine("Example-------------------------------");
             Example();
             Console.WriteLine("Example^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
             Console.WriteLine("Example2------------------------------");
             Example2();
             Console.WriteLine("Example2^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
             Console.WriteLine("Exercise-------------------------------");
             Exercise();
             Console.WriteLine("Exercise^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
             Console.WriteLine("ExerciseSwitch-------------------------");
             ExerciseSwitch();
             Console.WriteLine("ExerciseSwitch^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
             Console.WriteLine("FixThis--------------------------------");
             FixThis();
             Console.WriteLine("FixThis^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
             Console.WriteLine("TurnThisIntoASwitch----------------------");
             TurnThisIntoASwitch();
             Console.WriteLine("TurnThisIntoASwitch^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
        }

        static void Example()
        {
            /* STOP, continue here! After you complete this example, scroll down until I say stop again. */

            //Change age and see if you can get the different outputs below.
            int age = 5;

            /* you see here that we are checking if age is greater than OR equal to 18, that will evaluate
                to either true or false */
            if(age >= 18){
                Console.WriteLine("I'm an adult");
            }

            /* you see here that we are checking if age is less than to 18, that will evaluate
                to either true or false 
                NOTE, notice the equals sign is not included, we are ONLY checking that we are less than 18*/
            if(age < 18){
                Console.WriteLine("I'm not an adult");
            }
        }

        static void Example2()
        {
            /*
            STOP! Continue here...

            if statements can live on their own, but can also be paired with "if else" and else 
            
                Know that we can have as many else if's after an if, but can have ONLY ONE else.

                with this structure as soon as an evaluation is made, the other else if's aren't considered, 
                and if no evaluations are met, the else will be executed by default.

                In the Example above, we have two if statements, know that both of those ifs are going to be checked
                regardless of the original outcome

                When you complete, scroll on until I say stop again.
            */

            //see if you can get each of the below outputs by changing age.
            int age = 5;

            if(age <= 21)
            {
                Console.WriteLine("I'm an adult and can drink!");
            }
            //Oh snap, wtf is && , that's a logical operator, it simply means AND.
            // we are checking that age is less than 21 AND age >= 18, if both conditions don't evaluate to true
            // then we will not execute it's statement
            else if(age < 21 && age >= 18)
            {
                Console.WriteLine("Society says I'm adult but not worthy of booze.");
            }
            //same as above, we are checking that age is less than 18 AND age is greater than or equal to 13
            else if(age < 18 && age >= 13)
            {
                Console.WriteLine("Why don't people treat me like an adult?! UGH!");
            }
            //if the above evaulations aren't met, by default, we will execute this else
            else
            {
                Console.WriteLine("Legit, I'm a kid");
            }

            //Just so you know, we covered && is AND, so || is OR
        }

        static void Exercise(){
            /* 
                STOP! continue here...

                But...there's no code here!
                You are correct, follow the instructions and right your own dang code!

                When you are done, scroll on until I tell you to stop!
             */
            
            //create two int variables below and set them equal to whatever numbers you want

            //create a result variable and set it equal to the difference of your two previous variables

            //Output the result saying if the result is negative or positive using if statements
            
        }

        static void ExerciseSwitch(){
            /* 
            STOP! continue here...

            Learn on your own!

             Switch statements are very much like if/else just written a different way
             Google how to do switch statements in C# and do the above exercise with NO if / else's, 
             use switch instead!

             Do it.

             When you are done scroll down until I tell you to stop.
             */
        }

        static void FixThis(){
            /*
            STOP! continue here...

            There is a bug in the code below.  Know that computers do EXACTLY what you tell them,
            and they make no assumptions with what you give them... at least when you do things in 
            C# there are no assumptions.  Look at the code below and fix why we don't get Ryan's
            output.  

            When you are done, scroll down until I tell you to stop.
             */

             //consider this your input
            string whoWeTalkingAbout = "Ryan";

            //What can you add here to fix the problem?

            if(whoWeTalkingAbout.Equals("BOB"))
            {
                Console.WriteLine("What's up bob!");
            }
            else if(whoWeTalkingAbout.Equals("HENRY"))
            {
                Console.WriteLine("Man, Henry is the coolest!");
            }
            else if(whoWeTalkingAbout.Equals("RYAN"))
            {
                Console.WriteLine("Ryan, Ryan, he's our man!");
            }
            else
            {
                Console.WriteLine("Psh... like, whoever that is...");
            }
        }

        static void TurnThisIntoASwitch(){
            /*
            STOP! continue here...

            I hope you fixed the code above because it needs to be applied here as well.  Also,
            I hope you taught yourself how to implement switch statements. Also, and more importantly,
            management decided they don't like if else statements because they are old school.
            They read a book that said switch statements are cool and save money.  They don't, 
            but the author said they do.  So your job now is to refactor this to not use if / else's
            and instead use switch statements.  Good luck.
             */

             //consider this your input
            string whoWeTalkingAbout = "Ryan";

            //What can you add here to fix the problem?

            if(whoWeTalkingAbout.Equals("BOB"))
            {
                Console.WriteLine("What's up bob!");
            }
            else if(whoWeTalkingAbout.Equals("HENRY"))
            {
                Console.WriteLine("Man, Henry is the coolest!");
            }
            else if(whoWeTalkingAbout.Equals("RYAN"))
            {
                Console.WriteLine("Ryan, Ryan, he's our man!");
            }
            else
            {
                Console.WriteLine("Psh... like, whoever that is...");
            }
        }
    }
}
