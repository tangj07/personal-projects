///Project: 日本語 Random Time Generator
///Details: Randomly generates random times and display it Hiragana for language practice
///Created: 09/07/2022

#region variables
//variables
Random rng = new Random();
//temporary input
string input, answer, input2 = "";
//temporary arrays
int[] time = new int[2];
string[] jptime = new string[2];
//temporary placement for hour
int temphour = new int();
string jphour = "";
//temporary placement for minute
int tempminute = new int();
string jpminute = "";
#endregion

#region maindisplay
//opening line
Console.WriteLine("Welcome to 日本語(にほんご) Random Time Generator where you can practice reading/writing time in ひらがな!\n" +
    "\nBUT before you start, here are some things you need to do first." +
    "\nA にほんご keyboard to input the answer so make sure you have one installed if you don't already! :)" +
    "\nNow for the somewhat complicated part... If you have windows(I don't know how to use a mac so figure it out on your own ig lmaoo), please follow these instructions:\n" +
    "- Go to Control Panel\n- Click on Clock and Region\n- Click on Region\n- Go to the Administrative tab\n- In the Language for non-Unicode progams box, click on Change system locale...\n- Change the locale to Japanese and restart your pc" +
    "\nIt should be good now but if it isn't then RIP LOL IDK " +
    "\nAlso disclaimers cause I don't want to code alts...\n- じゅうしちじ not じゅうななじ\n- はっぷん not はちふん");

do //loop to continue asking user if they want to keep going
{   
    Console.Write("\nWould you like to generate a time?(yes(はい) or no(いいえ) question btw)   > "); 
    input = Console.ReadLine().ToLower().Trim();
    if (input == "yes" | input == "はい")
    {
        GenerateTime(rng, temphour, tempminute, time);
        temphour = time[0];
        tempminute = time[1];
        Hiragana(time, jptime, jphour, jpminute);
        Console.Write("Your generated time is:\t{0}:{1}\n\n今、何時ですか？(いま、なんじですか?)\n応答(おうとう): ", temphour, tempminute);
        input2 = Console.ReadLine().Trim();
        answer = jptime[0] + jptime[1];
        if (input2 == answer)
        {
            Console.WriteLine("You did it! :D");
        }
        else { Console.WriteLine("えーと —、try again..."); }
    }
    else if (input == "no" | input == "いいえ") { input = "no"; }
    else if (input == null) { Console.WriteLine("Bruh didn't even input anything."); }
    else { Console.WriteLine("That is not a yes or a no bruh :/"); input = "new"; }
} while (input != "no");
Console.WriteLine("Okay bye then I guess... :(");
Environment.Exit(0);
#endregion

#region generatetimemethod
static int[] GenerateTime(Random rng, int temphour, int tempminute, int[] time)
{
    //getting random numbers and assigning them
    temphour = rng.Next(1, 24);
    tempminute = rng.Next(1, 59);
    //putting them in the array
    time[0] = temphour;
    time[1] = tempminute;
    //returning the array
    return time;
}
#endregion

#region ひらがなMethod
static string[] Hiragana(int[] time, string[] jptime, string jphour, string jpminute)
{
    switch (time[0])
    {
        case 1: jphour = "いちじ"; break;
        case 2: jphour = "にじ"; break;
        case 3: jphour = "さんじ"; break;
        case 4: jphour = "よじ"; break;
        case 5: jphour = "ごじ"; break;
        case 6: jphour = "ろくじ"; break;
        case 7: jphour = "しちじ"; break;
        case 8: jphour = "はちじ"; break;
        case 9: jphour = "くじ"; break;
        case 10: jphour = "じゅうじ"; break;
        case 11: jphour = "じゅういちじ"; break;
        case 12: jphour = "じゅうにじ"; break;
        case 13: jphour = "じゅうさんじ"; break;
        case 14: jphour = "じゅうよじ"; break;
        case 15: jphour = "じゅうごじ"; break;
        case 16: jphour = "じゅうろくじ"; break;
        case 17: jphour = "じゅうしちじ or じゅうななじ"; break;
        case 18: jphour = "じゅうはちじ"; break;
        case 19: jphour = "じゅうくじ"; break;
        case 20: jphour = "にじゅうじ"; break;
        case 21: jphour = "にじゅういちじ"; break;
        case 22: jphour = "にじゅうにじ"; break;
        case 23: jphour = "にじゅうさんじ"; break;
        case 24: jphour = "にじゅうよじ"; break;
    }
    #region very long and probably not great code of assigning minutes but it's like 1am and i cant think rn
    switch (time[1])
    {
        case 1: jpminute = "いっぷん"; break;
        case 2: jpminute = "にふん"; break;
        case 3: jpminute = "さんぷん"; break;
        case 4: jpminute = "よんふん"; break;
        case 5: jpminute = "ごふん"; break;
        case 6: jpminute = "ろっぷん"; break;
        case 7: jpminute = "ななふん"; break;
        case 8: jpminute = "はっぷん"; break;
        case 9: jpminute = "きゅうふん"; break;
        case 10: jpminute = "じゅっぷん"; break;
        //
        case 11: jpminute = "じゅういっぷん"; break;
        case 12: jpminute = "じゅうにふん"; break;
        case 13: jpminute = "じゅうさんぷん"; break;
        case 14: jpminute = "じゅうよんふん"; break;
        case 15: jpminute = "じゅうごふん"; break;
        case 16: jpminute = "じゅうろっぷん"; break;
        case 17: jpminute = "じゅうななふん"; break;
        case 18: jpminute = "じゅうはっぷん"; break;
        case 19: jpminute = "じゅうきゅうふん"; break;
        case 20: jpminute = "にじゅっぷん"; break;
        //
        case 21: jpminute = "にじゅういっぷん"; break;
        case 22: jpminute = "にじゅうにふん"; break;
        case 23: jpminute = "にじゅうさんぷん"; break;
        case 24: jpminute = "にじゅうよんふん"; break;
        case 25: jpminute = "にじゅうごふん"; break;
        case 26: jpminute = "にじゅうろっぷん"; break;
        case 27: jpminute = "にじゅうななふん"; break;
        case 28: jpminute = "にじゅうはっぷん"; break;
        case 29: jpminute = "にじゅうきゅうふん"; break;
        case 30: jpminute = "さんじゅっぷん"; break;
        //
        case 31: jpminute = "さんじゅういっぷん"; break;
        case 32: jpminute = "さんじゅうにふん"; break;
        case 33: jpminute = "さんじゅうさんぷん"; break;
        case 34: jpminute = "さんじゅうよんふん"; break;
        case 35: jpminute = "さんじゅうごふん"; break;
        case 36: jpminute = "さんじゅうろっぷん"; break;
        case 37: jpminute = "さんじゅうななふん"; break;
        case 38: jpminute = "さんじゅうはっぷん"; break;
        case 39: jpminute = "さんじゅうきゅうふん"; break;
        case 40: jpminute = "よんじゅっぷん"; break;
        //
        case 41: jpminute = "よんじゅういっぷん"; break;
        case 42: jpminute = "よんじゅうにふん"; break;
        case 43: jpminute = "よんじゅうさんぷん"; break;
        case 44: jpminute = "よんじゅうよんふん"; break;
        case 45: jpminute = "よんじゅうごふん"; break;
        case 46: jpminute = "よんじゅうろっぷん"; break;
        case 47: jpminute = "よんじゅうななふん"; break;
        case 48: jpminute = "よんじゅうはっぷん"; break;
        case 49: jpminute = "よんじゅうきゅうふん"; break;
        case 50: jpminute = "ごじゅっぷん"; break;
        //
        case 51: jpminute = "ごじゅういっぷん"; break;
        case 52: jpminute = "ごじゅうにふん"; break;
        case 53: jpminute = "ごじゅうさんぷん"; break;
        case 54: jpminute = "ごじゅうよんふん"; break;
        case 55: jpminute = "ごじゅうごふん"; break;
        case 56: jpminute = "ごじゅうろっぷん"; break;
        case 57: jpminute = "ごじゅうななふん"; break;
        case 58: jpminute = "ごじゅうはっぷん"; break;
        case 59: jpminute = "ごじゅうきゅうふん"; break;
    }
    #endregion
    //assigning the strings to the array
    jptime[0] = jphour;
    jptime[1] = jpminute;
    return jptime;
}
#endregion