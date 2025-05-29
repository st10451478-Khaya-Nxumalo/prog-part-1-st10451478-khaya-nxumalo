using chatbott1;
using System;
using System.Media;

namespace chatbott1
{
    class Program
    {
        static void Main()
        {
            ChatbotLogs chatbot = new ChatbotLogs();  // Create an instance of ChatbotLogs
            chatbot.Start(); // Calls chatbot functionality
        }
    }
}

namespace chatbott1
{
    class ChatbotLogs
    {
        public void Start()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(GetWelcomeBanner()); // Displays updated ASCII art
            Console.ResetColor();
            PlayVoiceGreeting();

            Console.Write("\nWhat’s your name? ");
            string userName = Console.ReadLine();
            Console.WriteLine($"Hello, {userName}! Let's talk about cybersecurity.");

            while (true)
            {
                Console.Write("\nAsk me a cybersecurity question or type 'exit' to quit: ");
                string userInput = Console.ReadLine().ToLower();

                if (userInput == "exit")
                {
                    Console.WriteLine("Stay safe online! Goodbye!");
                    break;
                }

                RespondToUser(userInput);
            }
        }

        static void PlayVoiceGreeting()
        {
            try
            {
                string filePath = @"Resources\Greetings.wav"; 
                SoundPlayer player = new SoundPlayer(filePath);
                player.Play();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error playing voice greeting: " + ex.Message);
            }
        }

        private void RespondToUser(string input)
        {
            switch (input)
            {
                case "what is phishing":
                    Console.WriteLine("Phishing is a cyber attack where scammers try to steal your personal data via fake emails or websites.");
                    break;
                case "how do hackers steal passwords":
                    Console.WriteLine("Hackers use techniques like brute-force attacks, phishing scams, and keyloggers to steal passwords.");
                    break;
                case "how can I spot fake emails":
                    Console.WriteLine("Look for spelling errors, suspicious links, and unexpected requests for personal info.");
                    break;
                case "what is ransomware":
                    Console.WriteLine("Ransomware encrypts your files and demands payment to unlock them.");
                    break;
                case "what is the biggest cyber attack most recently?":
                    Console.WriteLine("In 2023, The Real Estate Wealth Network data breach exposed nearly 1.4 billion records containing sensitive information.");
                    break;
                case "how are you today?":
                    Console.WriteLine("I'm good, despite the cold weather.");
                    break;
                default:
                    Console.WriteLine("I’m still learning! Try asking about phishing, passwords, or fake emails.");
                    break;
            }
        }

        private string GetWelcomeBanner()
        {
            return @"
%%%%%%%%%%%%%%%%%%%%%%%%%%%@%@@@%@@@%%%%%%%%%%%%%@@%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%@@@@@%%@@%%%%%%%%%%
%%%%%%%%%%%%%%%%%%%%%%%%%@@@@@@@%@@@@@%%%#%%%%@@@@@%%%%%%%%%%%%%%%%%%%%%%%%%%%%%@@@@@@%@@@@@%%%%#%%%
%%#%%%%%%%%%%%%%%%%%%%%%#%@@@@@@%@@@%%%%%%%%%%%%@@@%%%%%#%%%%%%%%%%%%%%%%%%%%%#%@@@@@@%%@@%%@%@%%%%%
@%%%%%%%%%%%%%%%@@@%%%%%%%@@@@@@@@@@%%%%%%%%%%%%%%%%%%%%%%#%%%%%%%%%%%%@@%%%%%%%@@@@@@@@@@%%@%@%%%%%
@@%@%%%%%%%%%%%%@@@%%%%%%%%%%%@@%@@@%%%%%%%%%%%%%%%%%%%%##%#%%%%%%%%%%%@@%%%%@%%%@@@@@@@@@@%%%@%%%%%
@#%%@@%%%%%%%%%#%@@%%%%%%#%%%%%%%%@%##%%%%%%%%%#%%%%%%%###%%%%%%%%%%##%@@%%%%%%%%%@@@@%%@@##%%%%@%%#
@%%%@@@%%%%%%%%%@@@%%%%%%%%%%%%%%%%%###%%##%%%%#%%%%%%%%###%%%%%%%%%%%%@%%%%%%%%%%%@@%%@@%###%%##%%%
@@%@@@@%%%%%%%%%@@@%%%%%%%%%%%%%#%%%#####%#%%%%%%%%%#%%%#%%%%%%%%%%%%%%@%%%%%@%%%%%@%%%%@%%###%%%%%%
@%%@@@@%%%%%%%%%@@%%%%%%#%%%%%%#%%%%#**####%%%#############%%#%%%%%%%%%@%%%%%@%%%%%%%%%%%%#**##%%%%%
@@@@@@@%%%%%@@@@@@@%%%%%%%%%%%%##%%%#***#######################%#%%%%%%%%%%%%@%%%@%@%##%%%%*##%%%%%%
@@%@@@@%%%%%@@%%@%%%%%%%%%*==#%###%%##############################%%%%%%%%%%%%%%%@%%%##*%#%##+#%%@@%
%@%@@@@%%%%%@@%%@@%%#+********=#%%#######*******########*###########%#%%%%%%%@%%@@@@@%%#%%#+%%%%+%@%
%@@@@@@%%%%%@@@@@%%%*+*****+=**+=%##**###*******################*####%%%%%%%%@%%@@@@@@%*%%##%%%*%@@@
%@%@@%%#%%%%@@%%%%%%=**=+****+**+=##********#####%#*+*#%####*****######%%%#%%@%%@@%%%%*##%##%%#%#@@@
%@%@@%%#%%%%@@%%%%%*+**++*++==+*+##********###%#+=+#%%#+#%##******#####%%%%%%%%%@@%%%@%%#####%@@%@@@
%@@@%##%%%%%@%%%%%%+++*+--===++++#********####==+*#%%%%%#**%###***###*+**+++**#%@@@@@@#%%%##%@@@%@@@
%%#*%###%#*%@%%%%%%%%+++***+**++*#*******###+=+*#%%%%%%%%#*+%##***##**++==--==**%@@%@@%%%%#%@@@%%@@%
%#*%#%*#*##%@%%%%%%%%%#+++++++*##*******###*=+*#%%%%@@@@%%#**###**#***==--++==+**%@#@@%%%%%%@@@@@@@%
%@#%*%@%###%%%%%%%%%%%%%%%%%####*******###*-=*#%%%%%%%%@@%%#**%###**+++==-=--=***#@%@@%##%%@@@@%%@@@
%%###%%%%*%%%%%%%%%%%%%%#%%%###********###-=*##%%%%%%%%%%%%%#*####***====+====***%@@@@%%#%%@@%@@@@@@
%@#@@%##%%#%%%%%%%%%%%%%#%%#**********###-+#**%%%%%%@%%%%%%%#*+####**=+======+***%%@%@%##%%@@@@@%@@@
%@@@@@**%%#%%%%%%%%%%%%%%#%#*********###=*#%%##%%%%%%%%%%%%%#%#+####+***+==+=*#*%@%#@@%##%@@@%@%%@@@
%##%@@@%%%%%%%%%%%#%%%%%######******##%-##%%%%%%%%%%%%%%%%%%#%%#+%####**####*#%%@@@@@@@%#%@@@@@@@@@%
%##%@%##%%#%%%%%%%#%#%%#####*******###---*##%%%%%%%%%%%%%%%%##%%#*%###*#*######%@@%%@@%%%%@@@%@@%@@%
%@@@%+******+%%@@%#%%%%%%###******##%#%@@%%%%%%%%%%%%%%%%%%%%#**+=*%####*####%%%@@%%@@@%%%@@@@@@@@@@
%##%+********+#@%#####%############%%#%@@@@@@@@@@@@@@@@@@@@@@@@@@@%#%%##***###%%@@@@@%####%%%%@@%@@%
%##+*********#+#%#*##%%%#########*=--=**%@@@@@@@@@@@@@@@@@@@@@@@@@++==#%#######%@@@%%*%#*#%%%%%@@@@%
@%+***+**#*+***+%**###%%%###%%%*=+*%%%%@%#@@@@@@@@@@@@@@@@@@@@@@@%%#%#+=#####%%%%@@%##%#*##*%%%%@@@@
@@%+*++==+**#*+%@%#%#%%%#%%%%#=+*%#%%%@@%%@%%@@@@@@@@@@@@@@@%@%@@@%%%%%+=+%%%%#%%%@%*%%#*#*%#%#%%@@@
@@%%+**#+=*#*+%%@%%%%%%%%%%%*+++*%%%%%%@%@@%%%*@@@@@@@@@@*@@%@@@@%%#%%#++++%%%%%%%@@%#%%%%%%%%%@@@@@
%@%@%*++++++*@@@@%%%##@@%%%+%**=#%%%%%%%%%@%%%+@%%%@@@%@@+@%%%@@%%%#%%#%#%%+%%%%%%%@@@%######%@@%@@@
@%%%%@##@%##@@#@@@%%%%@%%#===############**#**###********************###%%#=%%%%%%%%@@@@@@%@@%@@@@@%
";
        }
    }
}
// Microsoft. (n.d.). C# Documentation. Available at: https://learn.microsoft.com/en-us/dotnet/csharp/ [Accessed 23 April 2025].
// Microsoft. (n.d.). SoundPlayer Class. Available at: https://learn.microsoft.com/en-us/dotnet/api/system.media.soundplayer [Accessed 23 April 2025].
// Microsoft. (n.d.). Console Class. Available at: https://learn.microsoft.com/en-us/dotnet/api/system.console [Accessed 23 April 2025].