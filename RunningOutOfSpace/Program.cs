using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunningOutOfSpace
{
    class Program
    {
        static void Main(string[] args)
        {

            int fine1 = 0;
            int fine2 = 0;
            int fine3 = 0;
            int fine4 = 0;
            int fine5 = 0;
            int fine6 = 0;
            int fine7 = 0;
           

            
            Console.Write("      O\n     |#|\n      |\n\n     This is you. What's your name? ");
            string name = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\n     This is going to be the color of your choices. Choose by typing odd or even numbers.");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("\n     Hit enter to proceed with the story when it pauses.");
            Console.ResetColor();
            Console.ReadLine();
            Inizio:
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n     Greetings, Captain " + name + ". You're serving a great purpose with this space mission. \n     Everyone on the planet is thrilled for you to find glory and adventure...");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\n     even- It's an honor to serve you, my Emperor!\n     odd- I...I'm not sure about going...");
            Console.ResetColor();

            int brave = SceltaImperatore();
            if (brave % 2 == 0)
            {
                Console.WriteLine("\n     \"It's an honor to serve you, my Emperor!\"");
                Console.WriteLine("\n     The Emperor's proud gaze follows you while you exit the royal Chamber, and your heart swells up in expectation.\n     .\n     Then you trip on your own feet and fall into a decorative fountain.\n     You luckily don't see the Emperor's facepalm.");
            }
            else
            {
                Console.WriteLine("\n     \"I...I'm not sure about going...\"");
                Console.WriteLine("\n     The Emperor looks you right in the eyes, his stern gaze heavy in the silence. You don't dare stutter anything but:\"I-it's an honor...\".\n     Then you leave the royal Chamber with your tail between your legs. ");
            }
            Console.ReadLine();


            Divisione();

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("     Captain... Captain? "+name+"!");
            Console.ResetColor();
            Console.ReadLine();
            Console.WriteLine("\n     The voice of your firts officer snaps you out of a stupor. You turn to them: \"What?\"");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\n     It's...Is that a cactus?");
            Console.ResetColor();
            Console.ReadLine();
            Console.WriteLine("\n     You look in the direction that your officer is pointing, and you find a blooming cactus sitting in a corner of your perfectly minimal ship.\n \n     \"What!\"");
            Console.ReadLine();
            if (brave % 2 == 0)
            {
                Console.WriteLine("\n     It's been a long journey since you fell in the Emperor's fountain, but you didn't find the glory they promised you.\n     You faced the interminable, boring emptiness of space, without meeting anything: not life, not another planet, not even some cosmic dust." +
                    "\n     In the end, you and your first (and only) officer decided to return to the home planet, escaping the void.");
            }
            else
            {
                Console.WriteLine("\n     It's been a long journey since you fled from the royal Chamber: you faced the interminable, boring emptiness of space, without meeting anything: not life, not another planet, not even some cosmic dust." +
                    "\n     In the end, you and your first (and only) officer decided to return to the home planet, escaping the void. Although you really don't want to face the Emperor again...");
            }
            Console.ReadLine();
            Console.WriteLine("\n     But now a cactus plopped into existance, simingly out of nowhere.");
            Console.WriteLine("\n     Your officer looks at you, waiting for your orders, but you really don't now what to do.\n     You look at the cactus like it is going to tell you.");
            Console.Write("\n      O\n     |#|\n   O  |\n");

            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\n     even- Yup! It really looks like a cactus. Just leave it there \n     odd- Go and investigate the damn thing.");
            Console.ResetColor();

            int choice = Scelta();

            if (choice % 2 == 0)//lasci la pianta
            {
                Console.WriteLine("\n     You eye the plant suspiciously. It stands still and innocent, and its flower even looks pretty.");
                Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("     " + name +"...");
                Console.ResetColor();
                Console.ReadLine();
                Console.WriteLine("\n    You hear the urgency in your companion voice. You turn again towards them.\n     The slick interior of your futuristic command deck is now decorated by coat rack, a pink garden flamingo and bowling ball." +
                    "\n     \"What the-!\"");
                Console.Write("\n      O\n     |#| O\n   O  |  O\n");

                Console.ReadLine();
                Console.WriteLine("\n     It's a mystery why and how some 21st century's antiques started appearing in your ship, but you don't have a good feeling about it.");

                Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("\n     even- Maybe we can throw this stuff overboard... \n     odd- Keep it! you can always sell it later ;)");
                Console.ResetColor();

                choice = Scelta();

                if (choice % 2 == 0)//lancia cactus
                {
                    Console.WriteLine("\n     You head towards the cactus and grab it, with the intent to push it in the decompression chamber and out of the ship, but a thought hits you...\n     " +
                        "What if it's an anomaly of this space region?");
                    Console.ReadLine();
                    Console.WriteLine("\n     In the meantime an armchair and some barrels appeared.");
                    Console.Write("\n   O  O\n   O |#| O\n   O  |  O\n");

                    Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("\n     even- Just throw the stuff, damn it! \n     odd- I will double the speed to home!");
                    Console.ResetColor();

                    choice = Scelta();
                    if (choice % 2 == 0)//lancia cactus!!!!
                    {  
                        Console.WriteLine("\n     You decide to prioritize the launching of stuff, but it keep coming." +
                            "\n     So you order your first officer to help you (they've been watching you deal with the anomaly with an amused look on their face).");
                        Console.ReadLine();

                        Divisione();
                        Console.ReadLine();
                        Console.WriteLine("\n     In the end, you get finally home on your planet. You are exausted, and you enter the athmosfere followed by a trail of junk." +
                            "\n     A very unelegant way to get back, but hey, home it's home.");
                        Console.ReadLine();
                        Console.WriteLine("\n     Too bad that in the rush of throwing stuff, you throw your first officer too." +
                            "\n      They lands safely, don't worry. But you end up scrubbing dishes for the months to come.");
                        Console.ReadLine();
                        Console.WriteLine("\n     At least now you have a crazy tale and a pink flamingo to sell.");
                        Console.Write("\n      O\n     |#|  <----- dishwasher\n      |\n\n    ");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("\n\n     THE END #1: frantic!");
                        Console.ResetColor();
                        fine1 = 1;

                    }
                    else//double the speed
                    {
                        Console.WriteLine("\n     You order to your officer to double the speed with a tinge of panic in your voice, and they obey right away." +
                            "\n     Then both of you proceed to launch the mysterious objects out of the ship. It's a heavy and unpleasant job, but some stuff is really cool and you even keep something for yourself.");
                        Console.ReadLine();
                        
                        Divisione();
                        Console.ReadLine();
                        Console.Write("     In the end, you get home safe and sound, maybe a little tired." +
                            "\n     The celebration for your return it's not ready, mosly because you didn't even left yet.");
                        
                        Console.ReadLine();
                        Console.Write("     You pushed the speed so much, and you arrived so ealy, that you even travelled time." +
                            "\n     Scientists are very interested in you and your adventure now.");
                        Console.Write("\n      O      O\n     |#|    |#|\n      |      |\n\n    ");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("\n\n     THE END #2: time travel!");
                        Console.ResetColor();
                        fine2 = 1;
                    }



                }
                else//keep the stuff
                {
                    Console.WriteLine("     You decide to keep the stuff. I mean, it look in good condition too." +
                        "\n     While you think about money, a crate full of walnuts, twelve raccoons and a stack of newspapers joined the collection." +
                        "\n     After fifteen minutes you snap out of your toughts again, and you find that the objects have multiplyed until now.");
                    Console.ReadLine();
                    Console.WriteLine("     \"Rel'ha?\" you call for your first officer. But you can't even see them anymore!");
                    Console.Write("   OOOOOOO\n   O  O  O\n   O |#| O\n   O  |  O\n");
                    Console.ReadLine();
                    Console.WriteLine("     You need to act fast!");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("\n     even- Try to find your friend. \n     odd- Maximum speed to home - they will help us!");
                    Console.ResetColor();

                    choice = Scelta();
                    
                    if (choice % 2 == 0)//cerca amico
                    {
                        Console.WriteLine("\n     You fight against the useless stuff that keeps appearing, calling in the meantime for your companion." +
                            "\n     But the pressure keep getting stronger...");
                        Console.ReadLine();
                        Divisione();
                        Console.ReadLine();
                        Console.WriteLine("\n     Your ships explodes, several lightyears from your planet. " +
                            "\n     You're lucky tho." +
                            "\n     Rel'ha, your first officer and friend, heard you calling, and they are a lot stronger than you. They managed to get themselves and your passed out ass on an emergency capsule.");
                        Console.ReadLine();
                        Console.WriteLine("\n     But how are you going to get home now?!" +
                            "\n      After several months of the same poor-flavoured rations, you start wondering what that cactus tasted like.");
                        Console.Write("\n      O      O\n     |#|    |V|\n      |      |\n\n    ");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("\n\n     THE END #3: lost in space!");
                        Console.ResetColor();
                        fine3 = 1;
                    }
                    else//pipù veloce!
                    {
                        Console.WriteLine("\n     You press the console deck's buttons, since you can still reach them. The ship jumps forward, and the acceleration slams you against your seat.");
                        Console.ReadLine();
                        Console.WriteLine("\n     You pass out.");
                        Console.ReadLine();
                        Divisione();
                        Console.ReadLine();
                        Console.WriteLine("\n     You wake up in an hospital bed. Apparently, you made it home. <3");
                        Console.WriteLine("\n     When on the planet the ground crew saw that the ship wasn't slowing down, they activated an emergency energy net to catch you.");
                        Console.ReadLine();
                        Console.WriteLine("\n     The stuff on your ship is still multypling tho.");
                        Console.Write("\n   O  O\"\n   O |#| O <---- this is going to be a problem\n   O  |  O\n");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("\n\n     THE END #4: too much stuff!");
                        Console.ResetColor();
                        fine4 = 1;
                    }
         
                }


            }
            else//indaga
            {
               
                Console.WriteLine("\n     You stand up and head toward the mysterious plant." +
                    "\n     At first glance, it look like a perfectly normal cactus, but as you lean closer, you see it's made by tiny rounded marbles." +
                    "\n     \"What the-\"");
                Console.ReadLine();
                Console.WriteLine("\n     While you examine the fake(?) cactus, a stapler and a Cuckoo clock appear nearby.");
                Console.Write("\n      O\n     |#| O\n   O  |  O\n");
                Console.ReadLine();
                Console.WriteLine("\n     You don't know what to think.");
                Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("\n     even- Take a cactus sample. \n     odd- Up the shields!");
                Console.ResetColor();

                choice = Scelta();


                if (choice % 2 == 0)//sample
                {
                    Console.WriteLine("\n     You put on some gloves, and pinch away some of the minuscule beads from the object." +
                        "You pass the sample to your first officer, which is the \"science one\".");
                    Console.ReadLine();
                    Console.WriteLine("\n     In the meantime other stuff popped in, like a tanning bed and a stack of tires.");
                    Console.Write("\n   O  O\n   O |#| O\n   O  |  O\n");
                    Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("\n     Oh my gods... It' multiplying!");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("\n     even- Kill it with fire! \n     odd- Decompress the room.");
                    Console.ResetColor();

                    choice = Scelta();
                    if (choice % 2 == 0)//fire!
                    {
                        
                        Console.WriteLine("\n     I don't know if you know what fire uses to burn, but I will tell you anyway.");
                        Console.ReadLine();
                        Console.WriteLine("\n     It's oxigen.");
                        Console.ReadLine();
                        Console.WriteLine("\n     You set on fire the first objects at hand, and you immediatly regret it." +
                            "\n     The fire spreads in an instant to every anomalous item in the room, and soon you pass out for the smoke and the lack of oxygen");
                        Console.ReadLine();

                        Divisione();
                        Console.ReadLine();
                        Console.WriteLine("     You're lucky tho." +
                            "\n     Your officer is a lot stronger and stubborn than you. They managed to get themselves and your passed out ass on an emergency capsule, bringing also the starmap to get home.");
                        Console.ReadLine();
                        Console.WriteLine("\n     In the end, you got back on your planet, even if a little late." +
                            "\n     And with a little late I mean 3 months late.");
                        Console.ReadLine();
                        Console.WriteLine("\n     Your family worried sick, but you are at home finally....");
                        Console.Write("\n      O\n     |#| <----- Horribly late \n      |\n\n    ");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("\n\n     THE END #5: tooooo late!");
                        Console.ResetColor();
                        fine5 = 1;
                    }
                    else//decompress
                    {
                        Console.Write("     You and your only officer run out of the command deck, and decompress the room." +
                            "\n     You hear the air escape and the deadly silence of space float in. After a couple of minutes, you press some more buttons and the air flows in the room again.");
                        Console.ReadLine();
                        Console.WriteLine("\n     No strange items in sight.");
                        Console.ReadLine();
                        Console.WriteLine("\n     Three hours later, a timid rubber duck appear. You decompress again.");
                        Console.ReadLine();
                        Divisione();
                        Console.ReadLine();
                        Console.WriteLine("\n     In the end, you reach your home planet with a sigh of relief." +
                            "\n     Well, you had to decompress the deck every few hours, and you were running low on air, but once reached your atmosphere, no more strange phenomenon.");
                        Console.ReadLine();
                        Console.WriteLine("\n     You're finally home .");
                        Console.Write("\n     \\O/\n      # <---- you don't have a rubber duck anymore tho\n      |\n\n    ");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("\n\n     THE END #6: decompresssss!");
                        Console.ResetColor();
                        fine6 = 1;
                    }

                }
                else//shield
                {
                    
                    Console.WriteLine("\n     With a tinge of panic in your voice, you yell at your officer to raise the shields." +
                        "\n     Nothing seems to happen. Everything is still.");
                    Console.ReadLine();
                    Console.WriteLine("\n     Your companion looks at you with their head tilted to the side.");
                    Console.ReadLine();
                    Console.WriteLine("\n     They are cute, like this. They remind to you a puppy.");
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("\n     Is everything ok, Captain?");
                    Console.ResetColor();
                    Console.ReadLine();
                    Console.WriteLine("\n     \"I have no idea, Rel'ha\" you admit, scratching your head");
                    Console.ReadLine();
                    Divisione();
                    Console.ReadLine();
                    Console.WriteLine("\n     You wait for a few minutes, and then for few hours, but nothing different happens." +
                        "\n     Eventually you reach your home planet, were your family and friends awaits you.");
                    Console.ReadLine();
                    Console.WriteLine("\n     The strange random items disappeared once you exited a very peculiar region of space." +
                        "\n     Who knows what wuold have happened if you hadn't raised your shields...");
                    Console.Write("\n     \\O/\n      # \n      |\n\n    ");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("\n\n     THE END #7: safe and sound!");
                    Console.ResetColor();
                    fine7 = 1;
                }

            }
      
            
            //Console.WriteLine("\n     THE END");
            
           
            int totale = fine1 + fine2 + fine3 + fine4 + fine5 + fine6 + fine7;
            Console.ForegroundColor = ConsoleColor.DarkYellow; 
            Console.WriteLine("\n\n     You found out "+totale+" endings of 7!");

            

            if (totale == 7)
            {
                Console.WriteLine("\n    You did it! Here is a cactus. <3");
                Console.WriteLine("\n\n      ___\n     /* *\\  /\\\n     |* *|_| *|\n     |* *_*__*/\n   __|*_*|__\n  |_________|\n   \\       /\n    \\_____/");
            }
            else
            {
                Console.WriteLine("\n    Keep exploring space!");
                
            }
            Console.ResetColor();

            Console.ReadLine();
            Console.WriteLine("\n\n\n     Thank you for playing, I hope you enjoy!" +
                "\n\n     Laura De Stefani.");

            Console.WriteLine("\n\n     You can find me on itch, twitter and instagram at @odris_den");

            Console.WriteLine("\n     Now, hit enter to go back at the beginning and try it again, or hit anything else to exit the game. ;)");

            ConsoleKeyInfo uscita;
            uscita = Console.ReadKey();
            
            {
                if (uscita.Key == ConsoleKey.Enter)
                {
                    goto Inizio;
                }
                else
                {
                    Environment.Exit(0);
                }
             
            }
        }
         
        public static int SceltaImperatore()
        {

            int brave;
            while (true)
            {
               
                if (int.TryParse(Console.ReadLine(), out brave))
                {
                    break;
                   
                }
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("     (Pssst! You need to write an integer number!)");
                Console.ResetColor();
            }
            return brave;
           
        }
        public static void Divisione()
        {
            Console.WriteLine("\n****************************************************");
        }

        public static int Scelta()
        {

            int choice;
            while (true)
            {

                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    break;

                }
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("     (Pssst! You need to write an integer number!)");
                Console.ResetColor();
            }
            return choice;

        }


    }

   

}
