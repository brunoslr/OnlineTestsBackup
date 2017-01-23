using System;
using System.Collections.Generic;
using System.IO;

class Solution
{

    private Stack<char> charS = new Stack<char>();
    private Queue<char> charQ = new Queue<char>();


    public void pushCharacter(char ch)
    {
        charS.Push(ch);
    }


    public void enqueueCharacter(char ch)
    {
        charQ.Enqueue(ch);
    }


    public char popCharacter()
    {
        return charS.Pop();
    }

    public char dequeueCharacter()
    {
        return charQ.Dequeue();
    }



}
/*
using System;

class Calculator
{
    public int power(int n, int p)
    {

        if (n < 0 || p < 0)
            throw new Exception("n and p should be non-negative");

        return (int)Math.Pow(n, p);
    }
}

class Solution
{
    static void Main(String[] args)
    {
        Calculator myCalculator = new Calculator();
        int T = Int32.Parse(Console.ReadLine());
        while (T-- > 0)
        {
            string[] num = Console.ReadLine().Split();
            int n = int.Parse(num[0]);
            int p = int.Parse(num[1]);
            try
            {
                int ans = myCalculator.power(n, p);
                Console.WriteLine(ans);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }
        }
    }
}
*/
/*
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static void Main(String[] args)
    {
        string S = Console.ReadLine();
        int integerValue;

        try
        {
            integerValue = Int32.Parse(S);
            Console.WriteLine(integerValue);

        }
        catch (FormatException e)
        {
            Console.WriteLine("Bad String");
        }
    }
}*/

/*
using System;
class Node
{
    public int data;
    public Node next;
    public Node(int d)
    {
        data = d;
        next = null;
    }

}
class Solution
{
    public static Node insert(Node head, int data)
    {
        Node newNode = new Node(data);

        if (head == null)
            return newNode;

        Node currentNode = head;
        
        while (currentNode.next != null)
            currentNode = currentNode.next;

        currentNode.next = newNode;

        return head;
    }

public static void display(Node head)
{
    Node start = head;
    while (start != null)
    {
        Console.Write(start.data + " ");
        start = start.next;
    }
}
static void Main(String[] args)
{

    Node head = null;
    int T = Int32.Parse(Console.ReadLine());
    while (T-- > 0)
    {
        int data = Int32.Parse(Console.ReadLine());
        head = insert(head, data);
    }
    display(head);
}
}

*/

/*
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static void Main(String[] args)
    {
        int[][] arr = new int[6][];
        int temp = 0;
        int hourGlass = int.MinValue;
        for (int arr_i = 0; arr_i < 6; arr_i++)
        {
            string[] arr_temp = Console.ReadLine().Split(' ');
            arr[arr_i] = Array.ConvertAll(arr_temp, Int32.Parse);
        }


        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                temp = arr[i][j] + arr[i][j + 1] + arr[i][j + 2] + arr[i + 1][j + 1] + arr[i + 2][j] + arr[i + 2][j + 1] + arr[i + 2][j + 2];
                if (temp > hourGlass)
                    hourGlass = temp;
            }
        }

        Console.WriteLine(hourGlass);
    }
}
*/


/*
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string binaryConversion = string.Empty;
        int countNumberOfConsecutiveOnes = 0;

        int temp = 0;

        char[] arr;

        while (n > 0)
        {
            binaryConversion += n % 2;
            n = n / 2;
        }

        //reverse string
        arr = binaryConversion.ToCharArray();
        Array.Reverse(arr);
        binaryConversion = new string(arr);

        for(int i=0; i< arr.Length;i++)
        {
            if (arr[i] == '1')
            {
                temp++;
                if (temp > countNumberOfConsecutiveOnes)
                    countNumberOfConsecutiveOnes = temp;
            }
            else temp = 0;
        }

        Console.WriteLine(countNumberOfConsecutiveOnes);
    }
}
*/

/*
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static void Main(String[] args)
    {

        int n = 2;
        int m = 2;
        int result = ackerman(m, n);

        Console.WriteLine(result);

    }

    static int ackerman(int m, int n)
    {
        if (m == 0)
            return n + 1;

        if (n == 0)
            return ackerman(m - 1, 1);

        return ackerman(m - 1, ackerman(m, n - 1));


    }
}

*/


/*
using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        Dictionary<string,string > myDictionary = new Dictionary<string, string>();
        string line = string.Empty;
        string[] words;

        for (int i = 0; i < n; i++)
        {
            line = Console.ReadLine();
            words = line.Split(' ');
            myDictionary.Add(words[0], words[i]);

        }

        do
        {
            line = Console.ReadLine();
            if (line != null)
            {
                if (myDictionary.ContainsKey(line))
                    Console.WriteLine(line+'='+myDictionary[line]);
                else
                    Console.WriteLine("Not found");
            }
        } while (line != null);
    }
}
*/
/*
using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static void Main(String[] args)
    {

        int n = Convert.ToInt32(Console.ReadLine());

        string[] words = new string[n];

        char[] myCharArray;
        string evenChars = string.Empty;
        string oddChars = string.Empty;

        for (int i = 0; i < n; i++)
        {
            words[i] = Console.ReadLine();
           
        }

        for(int i = 0;i< n; i++)
        {
            myCharArray = words[i].ToCharArray();
            for(int j=0; j<myCharArray.Length;j++)
            {
                if (j % 2 == 0)
                    evenChars += myCharArray[j];
                else
                    oddChars += myCharArray[j];

               
            }
            Console.WriteLine(evenChars + " " + oddChars);
            evenChars = string.Empty;
            oddChars = string.Empty;
            
        }
    }
}
*/
/*
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= 10; i++)
            Console.WriteLine(n + " x " + i + " = " +  n * i);

    }
}
*/
/*
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{
    
    // Complete the function below.
    
    static int minMoves(int[][] maze, int x, int y)
{

    minMoves(maze, x - 1, y - 1);
    minMoves(maze, x + 1, y + 1);
    minMoves(maze, x + 1, y + 1);
    minMoves(maze, x + 1, y + 1);


}

static int

static void Main(String[] args)
{
    string fileName = System.Environment.GetEnvironmentVariable("OUTPUT_PATH");
    TextWriter tw = new StreamWriter(@fileName, true);
    int res;

    int _maze_rows = 0;
    int _maze_cols = 0;
    _maze_rows = Convert.ToInt32(Console.ReadLine());
    _maze_cols = Convert.ToInt32(Console.ReadLine());

    int[][] _maze = new int[_maze_rows][];
    for (int _maze_i = 0; _maze_i < _maze_rows; _maze_i++)
    {
        string[] _maze_temp = Console.ReadLine().Split(' ');
        _maze[_maze_i] = Array.ConvertAll(_maze_temp, Int32.Parse);

    }

    int _x;
    _x = Convert.ToInt32(Console.ReadLine());

    int _y;
    _y = Convert.ToInt32(Console.ReadLine());

    res = minMoves(_maze, _x, _y);
    tw.WriteLine(res);

    tw.Flush();
    tw.Close();
}
}
*/
//using System;
///using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//class Solution
//{
//    /*
//     * Complete the function below.
//     */
//    static string[] checkDivisibility(string[] arr)
//    {

//        Dictionary<char, int> dictValues = new Dictionary<char, int>();
//        string[] result = new string[arr.Length];

//        int testNumber = 0;

//        for (int i = 0; i < arr.Length; i++)
//        {

//            testNumber = Convert.ToInt32(arr[i]);

//            if (testNumber < 10)
//            {
//                if (testNumber == 8 || testNumber == 8)
//                    result[i] = "YES";
//                else
//                    result[i] = "NO";
//                continue;
//            }


//            char[] charArr = arr[i].ToCharArray();

//            for (int j = 0; j < arr[i].Length; j++)
//            {

//                if (!dictValues.ContainsKey(charArr[j]))
//                    dictValues.Add(charArr[j], 1);
//                else
//                    dictValues[charArr[i]]++;

//            }

//            ///Checa valores com o caracter 0
//            if (dictValues.ContainsKey('0'))
//            {

//                if (dictValues['0'] >= 3)
//                {
//                    result[i] = "YES";
//                    continue;
//                }

//                if (dictValues.ContainsKey('8'))

//                {
//                    if (dictValues['8'] >= 2)
//                    {
//                        result[i] = "YES";
//                        continue;
//                    }

//                    if (dictValues.ContainsKey('2') || dictValues.ContainsKey('4') || dictValues.ContainsKey('6') || dictValues['0'] > 1)
//                    {
//                        result[i] = "YES";
//                        continue;
//                    }
//                }

//                if (dictValues.ContainsKey('4'))

//                {
//                    if (dictValues['4'] >= 1)
//                    {
//                        result[i] = "YES";
//                        continue;
//                    }

//                    if (dictValues.ContainsKey('2') || dictValues.ContainsKey('6'))
//                    {
//                        result[i] = "YES";
//                        continue;
//                    }

//                    if (dictValues.ContainsKey('1') || dictValues.ContainsKey('3') || dictValues.ContainsKey('5') || dictValues.ContainsKey('7') || dictValues.ContainsKey('9'))
//                    {
//                        result[i] = "YES";
//                        continue;
//                    }
//                }

//                if (dictValues.ContainsKey('2') || dictValues.ContainsKey('6'))

//                {
//                    if (dictValues.ContainsKey('1') || dictValues.ContainsKey('3') || dictValues.ContainsKey('5') || dictValues.ContainsKey('7') || dictValues.ContainsKey('9'))
//                    {
//                        result[i] = "YES";
//                        continue;
//                    }
//                }


//                result[i] = "NO";
//                continue;
//            }

//            //checa valores com caracter 8
//            if (dictValues.ContainsKey('8'))
//            {

//                if (dictValues['8'] >= 3)
//                {
//                    result[i] = "YES";
//                    continue;
//                }

//                if (dictValues.ContainsKey('4'))
//                {
//                    if (dictValues['4'] >= 2)
//                    {
//                        result[i] = "YES";
//                        continue;
//                    }

//                    if (dictValues.ContainsKey('2') || dictValues.ContainsKey('6') || dictValues['8'] > 1)
//                    {
//                        result[i] = "YES";
//                        continue;
//                    }
//                }

//                if (dictValues.ContainsKey('2') || dictValues.ContainsKey('6'))

//                {
//                    if (dictValues.ContainsKey('1') || dictValues.ContainsKey('3') || dictValues.ContainsKey('5') || dictValues.ContainsKey('7') || dictValues.ContainsKey('9'))
//                    {
//                        result[i] = "YES";
//                        continue;
//                    }
//                }

//                result[i] = "NO";
//                continue;
//            }

//            //checa valores com caracter 4
//            if (dictValues.ContainsKey('4'))
//            {

//                if (dictValues['4'] >= 2)
//                {

//                    if (dictValues.ContainsKey('2') || dictValues.ContainsKey('6'))
//                    {
//                        result[i] = "YES";
//                        continue;
//                    }

//                    if (dictValues.ContainsKey('1') || dictValues.ContainsKey('3') || dictValues.ContainsKey('5') || dictValues.ContainsKey('7') || dictValues.ContainsKey('9'))
//                    {
//                        result[i] = "YES";
//                        continue;
//                    }
//                }

//                if (dictValues.ContainsKey('2'))
//                {
//                    if (dictValues['2'] >= 2)
//                    {
//                        result[i] = "YES";
//                        continue;
//                    }
//                }
//                if (dictValues.ContainsKey('6'))
//                {
//                    if (dictValues['6'] >= 2)
//                    {
//                        result[i] = "YES";
//                        continue;
//                    }
//                }

//                result[i] = "NO";
//                continue;

//            }

//            //checa valores com caracter 6
//            if (dictValues.ContainsKey('6'))
//            {

//                if (dictValues['6'] >= 2)
//                {

//                    if (dictValues.ContainsKey('1') || dictValues.ContainsKey('5') || dictValues.ContainsKey('9'))
//                    {
//                        result[i] = "YES";
//                        continue;
//                    }
//                }

//                if (dictValues.ContainsKey('1') || dictValues.ContainsKey('5') || dictValues.ContainsKey('9'))
//                {
//                    result[i] = "YES";
//                    continue;
//                }

//                if (dictValues.ContainsKey('3'))
//                {
//                    if (dictValues['3'] >= 2 || dictValues.ContainsKey('1') || dictValues.ContainsKey('5') || dictValues.ContainsKey('7') || dictValues.ContainsKey('9'))
//                    {
//                        result[i] = "YES";
//                        continue;
//                    }

//                    if (dictValues.ContainsKey('7'))
//                    {
//                        if (dictValues['7'] >= 2 || dictValues.ContainsKey('1') || dictValues.ContainsKey('5') || dictValues.ContainsKey('9'))
//                        {
//                            result[i] = "YES";
//                            continue;
//                        }

//                    }
//                }

//                result[i] = "NO";
//                continue;
//            }


//                //checa valores com caracter 2
//                if (dictValues.ContainsKey('2'))
//                {

//                    if (dictValues['2'] >= 2)
//                    {

//                        if (dictValues.ContainsKey('7') || dictValues.ContainsKey('3'))
//                        {
//                            result[i] = "YES";
//                            continue;
//                        }
//                    }


//                    if (dictValues.ContainsKey('1'))
//                    {
//                        if (dictValues['1'] >= 2 || dictValues.ContainsKey('3') || dictValues.ContainsKey('5') || dictValues.ContainsKey('7') || dictValues.ContainsKey('9'))
//                        {
//                            result[i] = "YES";
//                            continue;
//                        }
//                    }

//                    if (dictValues.ContainsKey('5'))
//                    {
//                        if (dictValues['5'] >= 2 || dictValues.ContainsKey('3') || dictValues.ContainsKey('7') || dictValues.ContainsKey('9'))
//                        {
//                            result[i] = "YES";
//                            continue;
//                        }
//                    }

//                    if (dictValues.ContainsKey('9'))
//                    {
//                        if (dictValues['5'] >= 2 || dictValues.ContainsKey('3') || dictValues.ContainsKey('7') || dictValues.ContainsKey('9'))
//                        {
//                            result[i] = "YES";
//                            continue;
//                        }
//                    }

//                    result[i] = "NO";
//                    continue;
//                }



//                result[i] = "NO";
//                continue;
//            }


//            return result;

//        }
//    }

//    static void Main(String[] args)
//    {
//        string[] res;

//        int _arr_size = 2;

//        string[] _arr = { "123454", "1244543" };

//        res = checkDivisibility(_arr);
//        for (int res_i = 0; res_i < res.Length; res_i++)
//        {
//            Console.WriteLine(res[res_i]);
//        }


//    }


//}

///*
//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//class Solution
//{

//    static void Main(String[] args)
//    {
//        string a = "jqdckpobsappffqpomsxkciwiihizcqluvngmdjefytmfmbtywskaaiklrskukxqgkzspixwhsjoemkekcrkdbvotpapcyfikecanzywshmyuwfezyrczossfshhqppbtsditbgnjtofptlqreuqumlafuhvjzydtbnofucqnqvelixenrwhehhjcrglshqniedpyffnxatkjqowilfoupxygfmamcpxismiasxzurkdhabrnhfiweiemugyzvxhpkspcppygzcqbfjpopxmvfshcyibvfklpcctsrsaswsubcjqticopvyrvgutlfebjiwdaogumyqocbgvjkmbhkudqpwbwcehkblmrrjerzuubarmmdnunizfzvjvznclqpaiijoakkwnknayrpsgzroaoxvpkabdrdnambcynymxnoxefqnhhbhyafnmfqpytcyhfcgsaurokpuphjwqmeomjezquqqotrxatfvuzokjfgbmqxdcdtroxqgsgxibofehlbdmpnwxwzjmwoqckhqhxxbguljitnreovsgkqdgpouodlqpsgwsdaazljjezdkpydvkvarlplzuwpjrxhjdhjctuoztrkjrpebkfuxwgwqenbxliioqrslmgkhzuqqlxsyemvauusbhtyubhktadeolpwllobzlvxristemnfwgeqknbdngkerbaemqgnedkvlfrqrexpndixqlcgrmkknmpcexpiacgohxgabdqohynzlqhcetmuhdymapudrarazzbbcrrlrhncxugdquzxyzjapefigyjgxkjcdcnwjcaizgopanmanwdecimkhxsejdimgykrakabqoqtbdvqbywfhjrqikwsnfgvdrnfdnhwdxpgcmxfltmueempoihdppzugoamdjigizmnlluyhhsllecbpjgebfzjvbvymdeuerhqccqjljxwpbzenflonmxinthzynvfefxjhnuuwtqovrsiwfyjrvueqdfpqdwxitgrgclfydttuldsrbckyyppbwgrzcqhvyabblgzozuknzdgchqafhrigxzhzsrwqryrdgstioexphdrovutflbnjcukulhndhegpzzxpfufmzyaxuvegwrrbldxxkkctrijsjghpdodenebhbfpawgbkmahwljsctbuejdvosbthfwqgeggaojmakvzxerbzuxgfadwuepblnsuracuomgrycqvijykfvqmvviqaxtlnlfeniycwfvwhltrwrbdmtpjpybpxvckikpwunaquvodihvgyyjmsyvhyxywuagckxaenawhxmnhtintgyfaxbhvyftsgawszxzmzxuxkjgftuzzuectfjpfrkzzkyrkvsywquvcdchwygysnamuldccndbabtmynkvdhqhkuphuxhnkhbhsgjvtmyvorjofwjkdcsnyjwtgfgtmjahplekxcgnwrcdnnpqphgosehzkpuyywhphlzeqfuoxwrmjgdbqlpipyjbpdapzhegvdnnlhbkfuwocbrsmidegmfxshmtrqamwpbhyerdyntaplvdtahcopzgwoanecbctcjrgcwgspjjagmwgwyulzdhnfxujywedgxjktqckbllhajpwhjhgoqwvnqgomkruhafcsjnvvycvjrrqdaytsupimvwbinvrpcukmhfjhkgqbzigbiatfpbrmzswmqoeuioipvrwfzohywnzenvlewdtwxpknfokncseymcdlqmkoclvrggwdlrbjilyocidediepkkadymtayosexqjkhkvpyufaejghrnydzzixlcylssqpizarmximromyxuhqhgtihegugggaywqixszlphxjvljugskpagyhkeesmkskikuhettucqfycqukifzjnxsxdwrpgjbqwvyaqrutjbtlrnxauxlhwdgcaztijxbfuzhlsegbfzpzombllmuirdmtcfcncfuxeckwgqzlromhdnsobnytqkmuqqisvcrbebxktzyknksqymhbbfutqjogzwaxyuyfvyppxnbmavfykmblrwfhftpgrsfrmewhemydbcpbxubhidvabajivbomtwdfacmgonjppatoxuwfzrhatriqszelvhsxjedztmriokxlgvrgoyihrrxlsbynkqmwxpxqdobraadjxwrlwzuostbkwczisngrcekhunbxnggmcxxawtormsdkufsoszixfsebfhyunegrdfscyitmcywwdonwpvtwnzyuhwqwdyoidikdsfrventhdgdtbypqypmfmcbrarzfbkkurbpxoifupkpsjgljwxoicrzelakmkwgeyxbogiixtzregcncadmcwnghnsuarceraffioqfjpypxbezdjlhfypnmkjoblsslzztnrayjzngcrghctqiufxirgwuroodnoydfzbqarxckdjnyzvsgsaaywurmjwaxvdewgvwxuaizlvxmsqsksskppdbyadxxidtparmurwtcttollixddhusnysnbrmmufbxwprnonrhihttpqwuatonrgcuxogutjrrzkgnzzuhgpavgzsisgvjnzfmnmgivzzwkhljgitmxtjfubnmikxxjdjyrsgothndoypwgikgdulyxbmflmexpqviicybllhamyysijylfmlcnaiammxdctnmxlqizzklxjdfueszsgbfglhuyfxcamrzxhhwguhffnkztcylkbssnzmnglrixihxrrtzldessqrlvryfusyhtmuaymkxwsuolqpyvwqnmjahcypwsnelbalzowxlqtbdjsdeottbetkgtzcloixqlkrzgqkykndtggaubtxfninijsuyarqlbhnkyzkknofvwfryzpdoztwilqinjaznioxinhucxzxufpuggxuhsspdlaruashkggutqoynqvjvmddudxbvrrzctszvkigqpclhtjujhgevlhqogrmzkledddzpnhfejslceinlqrgbawqiqciapmgurfjgoqlzkyeogrbwjkalgquyuezlsfhjmqraiczsbdjjxkiiuitdapbuvchnhoyvgqvosxivcthzephaxdfxsjtoladvocqusokmnukporrugawfdccylvmyxrvntmjnctappkgddxzjywobasbnnplmhhzaviozbqoscwwfuxoutexvwzilowxvfwyaembhepzglxlhxzdqfbmbawmqsjoxhmzlaauepvkdtvmswqibtwctvqlnbzlilkvnlprckdhfywxwmixfgbabtnrunccaoxobohgblniljgixqheylgceutbjxdlndzprjvuwkdhwlrtbbabogfuayvlxbxneyexhbsflvnjggfjjfmxlssospzsqyfuxjugkmmxjbhrhmctrosegmubcwtsuyprjjatxmsgnzzwlbrepklywfbybutyukrdtrysfsysszrfaimrsxrresrgmkgiuxnprnhwghrygifgsranqrevkxdyijheiwwbkdyqlrqtbvctpciftocfmfguqnazlwavcalprbiszmooowvklypxfvtwkvxwuxtwafntixmjkczayvklvckazdykbvivvdtvkgotfccpgeqhbcswedyeixqjuagpdzmohdjnfneorwvsznqdsrjdqzokbvafwmvgpevxtzlnygfxvycqpovfpjprgrydgtlvzguuhhhfpnennjdcxyhmjyfqqdvwwgtxmqsvxzbnohabqffpfoeonjefpzdlhwltofpmesbvbdyuiejpspdhbkmqlpbtoomctdqaxrvzwttezevsuzzvlolwdoptfcyyhoahivgerblsfgkbhmysalpfcezhixhsnizvfhcyinrpvdtfprxrfoxhvyqfxxxmhyinfmnpbehwiabztbrarojmozsnzrzgsjvzvjrwpyvxayxvbqwtghfuhzhitiolsmmnxdmobjodhlzjdxejejfnlovgwmtoafexjqlmzzqimrrrovauhfkutfaqttgtaksjagwbfokufdlvzorivbcpjehcznwzyolauhccvoycrlxqboaxqemzivdjkblkswlofpsadqeuebnfpnchuqicnooypzihvvwakocphgknjzsyoxiipqndebbwaldxhbzrsbhzjtosuisifarvteazhbvhmbgtefnwiwxrrllludvbgmybsyazbyiqbolfvaedwbwpphalnwmtknuflwepwpfzfqhbrlgpodfdkhqzffsssoxfndujsblyusbnfhctkjzxtpwyursmhpuutoglqrlklmxqubjgnkfgaegwvzlcofzjvfxlykxjxwztykblxhrxlzviygkpnlajqxwqiuzhqaaqnbdkkwjvwedunqlabmluliktckcumenziqlsnuolztholtqnfchqktmofokstxtbqfvfzlqafxqqqhfxlooxicnnsxhlxbonikuhvkkchavajaxupnrzreokewxdzmshymqvwcaffvhoxflmuenmlcypavuzjmijyahwdhbicjyzqjomqdabfyshwmifyqrwrysufvejeckwoajeejhlkztglbnjuehncbjjwnudrfzfhkllwszgruoexbpriwekxnwwcqzuvabdlpqhjrpdlfhjgxcovjbvyxrbnsxlsaqfrimbadelilwrkzhiikdghwjxogkgjamaiabighwqvshftrpdbsmlovkceulpwxpeztpfalwvfddbwseanqldoxguttjpqatptkvuvrrdwwevpkvedihrfplaiwpywkqqvnmsgfvecbztmwxpeeilwvlercfpnxfiktaszywbzyulurcbxkotfcayeforcvbopcgqacrbannxgrydcozjqzivgyoktqykueauitxlgmimeisiwtrpubmazamvskhmqiiybgjkstwwdqecjyrfbdhbftyydfktptutbddtzbscuygfwxlyasbgmbgrgqlylfrmkwilxaqrywxvukvwcweozkihdtfoawdmslasnqllokiiudhxbnnaavifqpvsoyhilhayzmknwuytafqbufewdobtdxorxvajccjdqvqpqoiqvatqfzoknqgtpummpoxtthwjemyudimyigqqffavvgqkccyttymmhkvlzwgcescpathiyhdvqvhsxfoqfaemnayoygseautdpalnkqiclpwkxkdcnhrcjrqhzimbeheuipjufuwsjsdidgnsnguxxkgwusxaaeuktgebaavluyuzejrupltmxzktsjuunoejukmwmhigiciolzicnbombagvlapbqvknfyjrhrzpthegjoiyqyktasqmsfnjczyjxhcgzdyuledwsnwkmgfmbvatcnegmcplmrulvshiwkgqycdkkiylgzhkolrdqgqcakpxewfchntfpyrbirnosubhhskzycdansxrpeuyrpdinwkxnzogvppehzehbjiqchktoerhvuqkschfdvlymactbidfsnxwwhpkngsicksuocbrzprmrthtekayzzuwhliurafvmxrcbstbhkpzgwumjukktggcrpxkrchgbyidqegyovxwtricnupiavltmkfgomopmwudacdrxcnrvyvisksvifqwpwcdkqvxprcruhitjymewkoqwglemebdcfjmyglnxpetwppfnbllnzbkipqwttzvzijzqxmqmsjlhaqweehrdlbnaujvnlsmtblmyzcnulyboqasuhjasnpuhzpukjjflwrlytashavxrvpndapxnfswgjtsvcxgartymwqvwmspjhfmiwmxdgwjrpbmtbuvsouemmaiauakcfymdklhqhqiyuutvpppflvtzvbaqdmukkioxtvndnxbjuxejovqzrjyomagsoacbiqyennhdlkmfhtqvoiwhtxwfzcxofcppspticalpnzwwsosjwqqrnmzprwfwaulvlfdnhqfupbrksltodjgtyfipdnngjybufejpwqlluevmpqcvaioapwrvledweeqmkbbgumtorraihcdjntjerabcgeyliqxsuaaoowchnesugvetrnaiqblwglhoegjyiloxhsewwwrcuxylmytczgzfuiwyrhyzumyeedacbrevocidcefckgjgrhgkoejlsipynpaojfmzjucmykqlqzrjhytxcdkxnzvcrwqcdcdoxicxssiksaubanaeslbhmzjdxchaenqdvtbpljzflvilljqdutngsympavrhiikfbnuozuumrcycnqijlvsetevwbndmxnrydmocikozpoccgkmsheycktylibzfrrfufwwngmmvbqyjckblqboaxmnfqnnhgublqzaxlosofsyjezvudjwaxmhnbuuhrxuhwugiibyptwzyyuubftbcfisgfmnwkjfidmsnnrdincgnydofwrhbazjhoydahiikubzjscshgavgfllbdvefupmknrkuztgwwghqkzzrcuzhiljlgpqcfensvzpwuvuqdciqdihfeinmtyxbnpgutvnquenpbhhfjsvnaesemhtifsltkrndmcwhgjyiqhpczkrbqlietbmytardrhjgjhpsqnaiwrmwbdxtpfxiimiemcjfjulubamrpocmfokishbjpbtzpbdbdnimhujjwvcmmeartkcntdwkgpkvsnywchkkdtvzrxndenwzzymteifkzpgrfenhlarotoqkodpstmrsmdnqntboihfnnvvzvopqffdtlslegeythmjwhkkptrfhmcijsxaxffqsxdyghwzqkiorvyjosqxgsfqkdskkxccwgccpydglmuehvnxndvvxalkffurewtdexhuylajxwngtdfgiccgdpqkxmcdkxgpvojtzleyjtgdwnlhqpnvfffetjhdhqsegdzhqdfawnfvaqcqgrlnytrrcaulqppyuofltknszspaktsqkgdkzwbbzvnrmeqhtvuoijgjdvjnoeeakjkjilmjjbavgsebqapyjwjmtvaizgklpvuziiitklpqdvtvwivfgfuaaukzaukrrgtcobvaomsuilpgulnaqhcsbmrdjdxclqebtcciowcyirgeeuewbjofvhigmfjxvpbprfzibbijupnbjuxmdoraxchkhqjffkwxpxhrypcueqvpmvepjvpgxwshocouomtgjazhrbdytznfwtwfponomivbkjxavsgeufnljtjcuzkqsgxjwmyjutmgfjhcbpjxvyigruiltsdnbaxxnvihquovfvaimjfjjopbiyodssqvsnvfkdpbadyfayoojtytjnwtlkwgcpdxcyenetqeyolapbpyxptgcpaqayyenbdsaihgdxkelxgczxbwmucpmehoffusgykigrolqapeywgxtjtigxzseggjlabryocghqsyrjcphkoduhlagkskqatdcxwdnyjupduinyzujnxfwkfcuznmzgrbfogsoqpfvjnikmftzeaxpfalenafvribhpvwhkbcwpngdubfybcpicdmrftnwbqgsnczydewurcylfflihdqmiednxslakrtytuyzyutrytefysngvdudhxsgqdgavbaqwypwujoseuxdmklhpfmyegewknzhozzmapluabnevmjizurobgnimteygfhxfhjfwwzyxoetbobakuqoafwpzcnhivenequamvamkefnuiphcfvfntumvjvdgcskuomgkmuwtzjpjywmdrtqkpeiyclhegryuggeubapcjfmjbapvthhkmpiqbruhjubrailbkbeugsdjsuencmxqbfgezaniurbwzmajpefvylfqfldhxaxbhffgftqbmrylgywvectepauulzelbdmijtrqojuadunjukgaozedzyzlzdwajkisfbkulewqykzuuhuihyngymtxsrxbbivjjfdwmzomjnhfvbpecckapgyhxvkbffkrmnpaoenatwfqzvubxheoncxkzhlfovydkndzrszloebqbwtzfxpszncbwoillgowttvnmuycabsczmdejswlhzmepwrachwxatkmpirqmjulxzqhrmubnifceyfgfdffxquoalgmwayuzqdtcxuqfbulbzrgfyncojsrwzdtbdpbtswyrsqyvkjwmaeratvpfngbolwqrltmfpkwjauendczfgsgbnxgcdirqghhsawxpgwajqeywgxbmrhpeewgjexcmeleghexqaxzsbxohwqvnzltgjbppzrbffgmmmjcmhdekcvualppkciqnkiclbeqgmetyoxmxbshdnbeyttlxedlolpbntrvfwofmorlpksuzwyyruloyoboarppmimugbzsrtdgfyaewbenvpdvehlgacxmmjitminddtjirmonntckiffomsumwrbidjbptrtwkegdqvsdqunabupoolckfftipuxklsjxxpanmsreogfqdwgrhkcoqvwhrwrfocclsfbgzuloasefomxxwzmowixngruvtzilejudfhtizznplkmklyahjyxpptkisvwygsemzxuaxhpksdwfcxnlxmcmfnwykuwqmacnaypxggjakifmfuzegbqmqokalitzlvnluckclvcvdjjkekokleyevkggtzfgxurtzdxkyzfckomoybblhzrcmakfzslymetnhqxhrejcuysuzviixznjzxqbrbbghvtqnrxfxhjshbmgxuqwwdfvdvyuycafxuvmnurkbackerqdljzhmefpzfmxhoegibtxvmkznmjtfcwrlvaxbhpandzwrddcgyzbkjazyksdoqwznzyoipqxspukuzmaxncjzejxqdceubdhccyktoimecyabmdazhjyluxcacgudmdhqbrjqzxwbvwehbgjishumhymlgiqsoxkpouhorfrpeywfefoypilygzjokzhywrpmnxahcuwiuuoaaczpmmnulyivxrvvllhyikhmefvaalaanzrzlgvzedudvqygdfglrqzxvwxvhyxwzoxlwskawgdtydbbjjoazoavmxswvqsvgqidisfgalbzocazmrcnhcktzdpxvkudacikwotwbuxpzapnrraytltsqlrnvlqvnbhlraksxhhwjwlanlaiywdqhudcgwzvxghohrgeanckmnmbapkblnrshxwptvlqdsgklmqlbuvnjkpmzbnkogexdanyxyqaswndifokcmzlwoxxpmhftndynszmqpoimbnuhbgjpgwnwwkoitvdgycvqbhisysezfbijhtypqoomyewuzaaaeyshhbzfvgfbhpkqjkibywpxalrbntbtruazxcesilvpbffkqnnolcnnpgpdcqwtmzulbbglmbanjhzzxopkqfyinnnpfjlukhhnipyxtamckmdjcuttztbpgogoztkmbtzljaiccvemjjvldrgfkjwtzcjbwvnzookxqvbtqhfbqdowwxbigxbibkjxfwwwmjtdexwwedzvintgmwpvvqdwdmwkksgydcbhzzdddcanstugpjbkzghesfpezxddzgkygqejseymastrbwcddlhxqycpwhuxnfytvcepidckvxcztgcwrlujkyaifvfucdqxhuoqzsaxpewlkajdldoxdphkmpfosxncrbstuuqlbowlogpbldbruibgxiwsfjuznoshkkulyrzozopktqbqbfyanvuvgqwtgqcraxeaqdoptdbnwfdzmdzbywwhmsatkfmkeqkuualneoccvhbhlcjlyhsncvgmcsxgkjcekpuqdysbivivxtgybbldwtpynogxaiekxaccyudirodqhkqkldnjwfjjvpjxznhwplynheyysbrblhmylbjhistejcbirlggyhvgltefvvgifsjquuzcpsiywmjpzpvxwtdhokojhvum";
//        string b = "nfcjzemqwwrvkakjpijobmxpymbihxuwezgdduwbqnwbnjmervsukslkemsllpjpqpvtjrwcevdterxxnsrzkcjqredetmujcrenkcpqxsjdmiazctamyjernhviurrykxluabkxvtdhedigxivxuzojhlsddldnjoklpuknqnuutdaqnxphxdrgoljtwohhcrsundhdsdxliadwxsfwvycmjnfibopghiavnjafmyrxauvznawkbawkoesrskxasxxhixmxxfuzcpzrrxbsxadnexfyheybcxkmxzjueduguvzmsbgrblhhjmfsqgwudghafsxmytusougivnbyaiflwmensajyisaolxalqudgomqlbslbcqnzftoxvxxdsyrfxtqqqvwghpsihdmlwbkbuyapyassymxxfnnxikeszycibovzpgcjgfagftyfhvcokqmvcqndopnrgitvovhxchfhceojbryojmjlcwqsndltlerccyzehgokkcvovtcgfltjjjdymrsavjczjdgsjucwyakwtocbbymmhskwjcwgnagydmroivkivwerkjunhizqakmjokqekyepmveutqeqpljbufpdoovoykapuqthqxycveyqvcgmnsnjxcolrkcrwcgsubzkzaowemmbqungmbrmfgzwsbqqfwibyknzkbvopjqgdfosifeondkhhcxozgszqfyajvqyeiejoubwafknlxxuzuiacczuizurunpavwkjqlgstsiepfapzkrcnrwvstopifpdbbnupvoinwofbowbynflgdizyyogefkhhzbwuqgjouoqkkrkyyygbgfcfvijbusktwipoqzcmnswalgajegnnmpuhzfkuxwntgdhwekircgtontztamiodcvdhizfgmaprilvuwpweimtcmneavseapjhxiogwrvqzintecrlneersrvspnypcjyctpisgfihnxauctfpzjgrdbmuqmjswjwrygjgltnbtpvvjckilscqtqklcvdafcufidmuzbvsrsnauzkhroymekxjgclnefsnjgjkigcbyrbuqnbhebvimstsuffbkzovizfsfjtdcwzslabpcyyoqtinypoloeiydqqizjnefmytoaiqaigrcqgcfwnuawsfmlpnuctcqsvgufzuoflqwtsdpgzpeuusflhbnbfftcmnilhwsvmqqeugmtxspumufuwvvdaqgofobmkujymceiitefltbaohumcrpehvvmlwaxsmvfoapyvtfinhibqcpuveyccvqnstlkhirxkhvfaaopjwszbhvwowbqrtfjoqwvbnslwprzshobfhdiqafewiuodcxsutpvjkhhzagrhxvmgavwacbxmxlrbkjwebrplaykahejezymbvibzlalllcmwoicrctccrofysoetmquhzygmytxkymiowmfyfjbwxgxqwbljsgstgbfewfqutykpmrqratoybnqxobiijbbpcjuaqmxlnhazzqrzjhzmupkkrstatwsxfmaxyxilellfdehplgbhylrrgkrzhjzoxzoywwlcjwincrcnxfuvromxagyhrzyraopymabwzljbcnrbsnzlbnkctjlnklelzvlmvmkwzvydirhcegqitakpjxewjihkfswchgzibzmlqvqwbgewgqlsopozzxjgpijyqihujvfzqvxtdcpkudckuqjwnvcefnfvvmpejxfbudwyhnibqkoncxjrunvzbaxyomfzlkcgpaewomagyotcnetkuqjvtgvjvalglnmcosbegdkgreigkdsewczpkvahxlqkbenrxovdrfmkluswalawpcnbznjwbzhcdwvckqidxunjqhhqsjohlbjmrujuvswaordajldgfsrvzaoukcdxgokzivtfprgfijftwkbdctydvozftddzrpackthbknguwlnuvoxzjyefmemhhriagicsbktnxzhwkwqhnoiwondatsicjqcqbfkcpesmfzkqybzlrkjfznhsfruqkwglbtpsxhfcjpuhswsjgbqfqyzxrtobrwovpenonstwknfelxotbgyrgzrysfbmbqhtwuhlpaibqnfdnvxqcxjkxakrfmdjemecjlnyoxbgngjaeisigbsdcdwjrauxmyzxmmvcmyizftblcttkulpyqlkhlggaffxtuvvgtdfayglabekxszwkniuaoaavgaoaxjismnvlvgnwnathbrrozlpqmrlutawsjelytglooamdafkezcuapjqddczyevrnbenukaiabuedcohbsebkpspswptakkpmofiafragngkrxtsrzwbpqrjogcqsofgckpesihyxnkpmgjefhfwxyglgkbbzjjbvyinipogeaxrggxooekndsbldeocnyflynaheoplpmcxublifyyiszwvdkztifghugqbvfmmtqjnrxywxwhpxdnapmvyrbhoizpfebrzrcmibmgainqhqdigrfglhpzpoowsrptkrfuvuaveonmgswokbuvijwzxmvrdkkpesjbmjwqzmeieawocrlkchkcthtysgnyywzmixejjjrqjoelhsylzknvrjtlpjjpfkdpihbtsujciqprinfjxserbacsjmhqymigujamdjqozghjvmtvfzmizobkckbbxjhtujhxvynwgvgdhbyoakxcbaodmpgjaqeuzmswmftucbxkewagixijzxpmovxplcjlqdjelcynfvzjtaqczanzzclqykfjoqwewiihkgwsewdxytzxwnwxrjnpuubilzphhzqugomkkpjiljijyegpquhmqkubjlkrlcntrzfdqoodzwmxcvpsryehibjrmvkzyxsryxurmiulejlhecbvaickjndxloxjnrcopwfdfbqlkdsqfwlheqrpfvmqllbaddouatzhvpshvlycjlknbdchaqznebohecdgycnvtgcotcrcodrpgvyjlywpbmyhpdopfdkbjoperiiflzwuwxfivbzyoaffdvwlzimkydppozwzzvvxsafpehpujuboqxzrhnbftsxhstitqeqkgybkhqeqlhgdegwlvzrosoxmjghcmzmszodgejyrrfwxnulkuczosycdejfskulkiqsobriuygsnbdxvhyjbxledwkwgejqobjeccmxctppuumrdlaeininlujraukqvvvyzhvbcmqyicplnrpxezlpuujwrvnmqikprhqwvgufimqydhvkhgbddmzuhmgxwtoqagmymidxuwxadskmbnpeapyhdghazxqceecsmfrhdohhjttkijoiaosfwbhyyxcedezqlqzphiyqbrcjcsuegokeprcprewuivmunllwtjmwcqificlqqvvhpxwgcscmppidctzyeouhgeopgzfyxahmyeucywqqnztsuuqzkmirrwizvnauqhgqnasozkeojzigtafgnpzglhhiuhdkrlaemusnfwdqvmwrmdzbsyjffrozarmreoysjsfqplgmzdfliepbcyijpwjqpxjulhmwaumrfvfeanririlwhufwsqoinaebhqxjmmcrhixjvrrozfmgzsfrivbyvfbfyaokmtevbdeyuymwdbcetjxdhzdegejefarttvrwyxuvxirajvgeheiofnslseszejuzglvelrbizsllqrrxxzlcnfqhjkiptcozqjfbchjebuprogoliboxhggsqoilswkiirjkyvoapftfoiryjhvsndlfrtqlrcubvdouacwskpxazoylvvdkyqprjhcdlwehcsdexbwjsujskhdgeisczkvkrzndyukcopgnqdwizhajqfruokynuvxnvnsthevxtbljgjsfrurjaieouedqaagvnyowdluwmfgtqaahurtuczkydnpfqxafvqcybwxqddjtdldzdyuhxgfauwgmtirrbtpcrmswrdswpxwuvsdsykushcgclytotlqnzljrqdnhaldxdgpcrmwaodebbapwlijkttdlwttzewwifomwaiyqleuoellptucopfaoyvnfrlpwzbubjsuxxoldzytvvxjkelafgpkybzwcargllaikowopwjkrgwcmjerqubqvcmzeffqthafvwtntezmmxqzhvqxpupmwdnbjtteatjysfnnjmbyksxtnpqejhqikdlvygzbzlbtqoibckzocyhrozvzgnjrqwmrcoseztzpjislusayshpijkkpxtgpqvgujayityzcgrocjqaezpmibwaasgpidycmydwsbvwjnmlyclcecrodnodfvupasunrxjlyhhhuwuuahzejqvodjrlgnahguuxrfkrmtaipufqdewourczdvkjjlqphmobuasgttrjpwbtazhwtmvwhgfstyhakxbexunrpgcgefzegjazvvveddxwbgxneyudujwlpystftzmcblzyjgeodarlxeryyvujrgysatztulyxzxykfcykcpwcvncukwfceewezvawjytivtudvsnyjjcezeajcglhmjnnhnjqlfajyuouobuxnwbmccvekjnwsdjzstpgarpalfuzgqwtoafqebxommkepvgiqxoqpfrckncqgamuarngumuiygnocvwssmjjrcmbpqtxsfstzhbvvwetetjgohbitkukoinfyhdqoxlpeplzlrurkeyalzkhlgrzohgoqjheguukjhlwyiokomkznwgadabrhhgxrpdxjzktgxpghfqvtcvgzdicfjvmrdlkspjcqvxztmfauywnatubycdeobsheerxvablwykrmstgqruqmquluxriajpfnicklfyjdiapavyspslbifoeefnfpekepopatpjyxlpainsxhfzrknwpvlumpgqeuhgpwrnwceylsskbyjtizpzwcvitbyyxigogydcaianctadtlwbkndipyqjarjzbrohptmsbmhdhhjathefvhomfexhxijyaxipquhuirzsyisrqyxnhnbntzwrhfrhezzxtirczsuybortpoiwdjlxkiouphbuhctalkekcakfrcagskewuqtgajapqelxgeatqgevhqcasfglpmjjccqenswdwhddodwglcbuvgunlcaapjmtneyawuetdjyrmwyzzbuuhojsrmvivhbjlzlhtrczaaqoxqoysisbydwrprznybyjajswbvvbvnssegqyqkboqxgfofumgsxjeqhfleiitadzitxygzpywvfncazlszuwpddcjokcqnczjbzrcopbjuomwpxrotndythjjulzjpauralvqcwazkovanmoicuixdrgxefhuibnipiyrfasrqorfaipeexbhohfvpopxrefimfctiulyicglkvpqtryjafepvvmmztvmzzfhtqhcvnphjgyezwnadupypempxjdwikfcdpgycvfnbfrddfdgbueqythwckulvanypvytsfhvlyyofbxgwdzuwgsztnmqnbqewoxotejgfkxklutjzsgwayxtljjykzeipcwlihrnroafktoknuintfheosfaujijnguwnojhejmrecbrxjhsqoyeifgcpooeukajymqfxewchxvgicyyswebckftatxwgafemyllehplglrqproioulseqnemmcsmiyaikmmtbaaorqelhmzbztipgodsrxhbyjjivxdzxfprytcfhdigysyehdyabhbzrmjojopjufasaezijhqhaqnjunjxvkyowhchvusrzujbyilhsequuddqtonoylewugfscyjdsvftdqcxutrrywhrkxhkilifuqzwoicifhbjzeiwzcnxyurltaxemijiyigmsiwyryjretndvccwwtjsugwiofsopycjjzjaxsrboggjiihheqzazvkpccetcgcnfmoeghhuqngyynhegieffquhuaawjfkotavzhewzucasphyxqccxuzfozhmioyzhywhiadhuhhoyrmwjqygkzlazvnjjlkrmiaujfdfmlukeiinzhtlihmjebtpmfiaoiuzpaednaorjyeifzvqgjzmksczakzovwpkwtojweafcgpkfkaouzagucfupfkkbzuzukiqoixrqmdvzdlvcobysjshoerrfoqayyspiqiaelxfojcsxerpplzdqswvgoxhoqwyigyorvwhgybdeuvtgwyyoutvkteylcwtiujzqfgwejciezekvcijzdgjykijmeeubovttdrzntkruodrqlbpqjbpwjyipdfqtcjogdotwaktonkganysxzjtkkdzpksindytgomfoyyenklpylhvmtqwdtxsercrvakdpykfykklvvatijqueiqhbpbhhfaeimjxkueieovblxwtjmnnwfxyvyhegikowtnhnrrugpvtmsnvgcldkidhimlouvcrqragjtarkxkxrzuyefdopivyugmrdrivikbtfdkqbxpuylsctxqiflgatvrymbwwnxqsdakgzzaynvagstoagxacutcgwycjwsdzvqhurhuecvkxqbxwazauudcqbgbzbeawwhsoppstmfqcipakobeieiyhobhrihperksiznblsuncjnmaqsiwajeqklisuzxnjrvieztytgcewoeoinlkypbicldwkcmuthcagyybgbgerktazekxvnixanvnphhirlkzllbsojwftphvvusqhcpiplxeseplrbldmmvavtgqlplgjgztiodabaguexhxzsclezmbtuuejfmvlnowcrydrezxchubzxogwcjrwdvilkdyxrubiufbzgydpserruzoxifvoddznixmzuojovknbiqtdwkutjkqtslhxpimxgyzamkqjvenfwgkvqfozrgulrciikuisvjujtltqrgypmikepadhgzsabdioxsgsbbcxovnfdlupwhtljyusxnsbqcrpvxkyamvqjlvowsfsbygmyaexpwahbrxyrjwtvukgfhudbzyezerzgvywuzdvscvjltfinrosykycjwgkazjgvierjkobmjnacsiqjzkjjknvgwfivrrsbvjkfxluiyulsedbdpnpaamiwtrskimnfwxlvlfejbrcfwflnscntqwrjpjwxwjeuhprswxdzohhmpsahwncmluvcftzddezmvrguojtftariurrqhweuscxxvydaecmatsuiepnzsehmyaffwjzonwolxrlbtybnsxxypmxhqetqhavdmxuzvkksbwuwwxlqxipmumtntmdanbfzabaxllqojmlhlwzifoubdnqwcwyrxfszjswwfolqcwzoszwzptbuitsmpsdoyxnjsmfzaqqdmrthspgkkjetdxfspljpiwyaiealwsolljseyaqlkueptljjwsafrzhzfjmdbconlgtmhlxtfbiborklmmsdnzeslrymtmbfvwrehoxprhqfacqmokpcmwwxnujgjnlelekvshkjqcrqejfuuwygsvdfromcdzipeskybwkrybiekpyglzmeurlnizqlzycftmduknmiqwodlpjyoyekrqxzppnqqpvjcbdoqrxhplmcavbqvfanxymnpzffrdqvgwjwpgffurhwpknkqpzpnoefpkmgpdbvblrqtzxpshmjrbujqvzgjdnzpzfeehzfutynuxdmerwwusfmnguzmhybhfinohtictyyqdnvultqdacshxttgtwnzebnowysrwrhzeevpxnuyrohoicxbykcdnqrlqjcmcmngqkxqxrqoixfqzctzowccovnehssjefqwrnooheepdjhelaeayiemetslnkurrmqkceyjldaqohvajbcijiwpbparbxivjafnhgwujwkzfhzpidxunvjrmmiojslutskcygwjfgjkqkzaqyudugugscwdvjzqcjscqomxwxjmhlpxjjdfpxojakmxumnyvfantmkrlwgthvsqgvyyvmhvywssifsfmtvfhfytdeokzidggbgbnnwljqgtxybjtwqdbowhvmrwuucavkbkyzwjredqeebyatbdkzkfnebhygkuqngqpcaiifznlcnnwosipfncjqlhyvdrlmhaqjkzqlmbozqmpjueqjibbtkarqrecygskqracfeseuevfabxljymfjmyzdcbeitqalqesuwxrcuycwwnfucmdokcuofayzqzmifefcdwgywlusabpcqsraxnpcppdfqppwwuybsgbprxjszyuptnrqaiupyywopoknkkpdrquiodcpexgxmzppkjgijdyztlodxdgqwcbmiddmcjlpkaeujketpdukqiopowgkzjyjmbxrmiiwimrtyvmqaiasrokfnqrobrxpuuggcoemcvfdtutvcvqvmaczsvntmkiggrokhtwkqdplzkjefzbtbesvbhoqtyyzrnlzijlynamokvurwwlxafudnktgisicftbndmnsmziyudpszarbilevvydgsnixhjmmxzgjzqjvtyoubfxjtegocjuuxctgnfukgcvhuefqdtkgakpvovksggofjhnyojjwneeiljyoekugulciiocouqwfzlepvpmivsqgdowjbsrvdvgnjieebalalpqigercyjkdahmbbfwfbeuknyqqacqotiwaoneozorzxfazlygmdaysbpibtapolmobbuqclhbindjycpmhskbtbluunmlyabadwqghzhrmlbmpsyykjzdkkahxmsymtaprsvyrfsgsvshnrhyagdmsdvrpnrdjrtajqbdvtjnqbwdsddulhjfmexeuohdiafrrgwobfcrhaxbgcytjhzynwchmjmuksodakreqvvzyucexazihygvwkejurfgjtllgcpwanxyhzegadrjcxgykljgepmpkzaqbqobflbmlfvnjmwllflvsxbwoplyonrsfftktvxgautlgrwrwknohqmvgxvunmmsuidpfcvhwotcfrvebkskbhfjgdftrumncrcjtxspllttdoxgzrrayyjfboavioimflxyiqpwdipizopyfiagglnkbnfmcnajaykjqzftkwclktjrblzjymtbcypgoqpoqbzibgbncdyoyjizwhjuwcxydngtdxjvzjdapgpumnkkwsksavowxlwcycxdzhaaqfchmrdyeokcguwgpkepyctwercgaegskjbwcfwhtglbdikuuolsrhrxavfazosjxvhbafivowxrehnavbtoimoihtighcsgxbiahsvxosquzdvxeqnocbwjxgrekjlknvkwnfteajybovyvlojnrgwomqtxzghmbtiqaduamvcbqcwcsfrknoycerbfziuadetdinewkizbmxfffwpsmnushvagfwjiacokruhccifogkvlimfvacpjzppflapocfywzhybsdsypplxcqueuknubebpfsdjydfxnfbfivfzkqxmitsdffxhkyyrqdaoiiovnpcymhxwxwliqdlxlkgvieoajorsyhnmwskizjgzgthyxuviecfoitosjhkiozwmrgwtpdsxwbvvvtfzxknffdzrllzblxoedkzuprumspjpkpohzdphhqyuczvpwjvbwvvlmpzhhjytyndzsuizkgtohrddazewuckitjrcuqysfbuxvczhluwslzymaekwgwhcgagaqevxfrvctwkgqizcjzqkdcikzrofsuhkzcigtflpbxxtfwvoxnabqlnpcbwuxfhykphfwsuzpuswqqmofnrvaemcfkzeqidczkhveewvyorqgdgmsxjsbyxiiypagscfemckqyfooygvbnjwksqoqpybnnbvhgcnsexkccatagoetzcgrswkiulxkotrwvfoccaghazjhppcorkgkisufdrprkioineksfqzhqkqhavwtf";

//        char[] arrA = a.ToCharArray();

//        char[] arrB = b.ToCharArray();
//        Array.Sort(arrA);


//        Dictionary<char, int> dictA = new Dictionary<char, int>();

//        int deletionsNeeded= 0;

//        for (int i = 0; i < arrA.Length; i++)
//        {

//            if (!dictA.ContainsKey(arrA[i]))
//                dictA.Add(arrA[i], 1);
//            else
//                dictA[arrA[i]]++;

//        }

//        for (int i = 0; i < arrB.Length; i++)
//        {

//            if (dictA.ContainsKey(arrB[i]))
//            {
//                if (dictA[arrB[i]] < 1)
//                    deletionsNeeded++;
//                else
//                    dictA[arrB[i]]+=-1;
//            }
//            else
//                deletionsNeeded++;

//        }

//        foreach (KeyValuePair<char, int> entry in dictA)
//        {
//            deletionsNeeded += entry.Value;
//        }

//            Console.WriteLine(deletionsNeeded);


//    }
//}


//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//class Solution
//{
//    /*
//     * Complete the function below.

//    static string[] checkDivisibility(string[] arr)
//{

//    string[] result = new string[arr.Length];

//    int testCase = 0;

//    for (int i = 0; i < arr.Length; i++)
//    {
//        testCase = Convert.ToInt32(arr[i]);
//        if (testCase < 10)
//        {
//            if (testCase == 8)
//                result[i] = "Yes";
//            else
//                result[i] = "No";

//            }
//        else if (testCase < 100)


//        }

//    return result;

//}



///*
//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//class Solution
//{

//    static void Main(String[] args)
//    {
//        string[] tokens_n = Console.ReadLine().Split(' ');
//        int n = Convert.ToInt32(tokens_n[0]);//Number of elements
//        int k = Convert.ToInt32(tokens_n[1]);//Number of rotations
//        int q = Convert.ToInt32(tokens_n[2]);//Position to print
//        string[] a_temp = Console.ReadLine().Split(' ');
//        int[] a = Array.ConvertAll(a_temp, Int32.Parse);
//        int[] m = new int[q];
//        for (int a0 = 0; a0 < q; a0++)
//        {
//            m[a0] = Convert.ToInt32(Console.ReadLine());
//        }

//        int[] aClone = new int[a.Length];
//        Array.Copy(a, aClone, a.Length);

//        for (int i = 0; i < n; i++)
//        {
//            a[(i + k) % n] = aClone[i];
//        }



//        for (int a0 = 0; a0 < q; a0++)
//        {
//            Console.WriteLine(a[m[a0]]); ;
//        }

//    }
//}
//*/


///*
//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//class Solution
//{

//    static void Main(String[] args)
//    {
//        string time = "07:05:45PM";

//        DateTime date = DateTime.Parse(time, System.Globalization.CultureInfo.CreateSpecificCulture("en-US"));

//        string t = date.ToString("HH:mm:ss");


//    }
//}
//*/


///*
//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//class Solution
//{

//    static void Main(String[] args)
//    {
//        //int n = Convert.ToInt32(Console.ReadLine());
//        //string[] arr_temp = Console.ReadLine().Split(' ');

//        int n = 6;


//        int[] arr = { -4, 3, -9, 0, 4, 1 };//  Array.ConvertAll(arr_temp, Int32.Parse);

//        double positive = 0;
//        double negative = 0;
//        double zeroes = 0;

//        for (int i = 0; i < n; i++)
//        {
//            if (arr[i] > 0)
//            {
//                positive++;
//            }
//            else if (arr[i] == 0)
//            {
//                zeroes++;
//            }
//            else negative++;
//        }

//        Console.WriteLine(string.Format("{0:0.000000}", (positive / n)));


//    }
//}

//*/


///* Bubble Sort*/
///*
//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//class Solution
//{

//    static void Main(String[] args)
//    {
//        //int n = Convert.ToInt32(Console.ReadLine());
//        //string[] a_temp = Console.ReadLine().Split(' ');
//        //int[] a = Array.ConvertAll(a_temp, Int32.Parse);

//        int n = 3;
//        int[] a = { 3, 2, 1 };

//        int temp;
//        int totalNumberOfSwaps = 0;

//        for (int i = 0; i < n; i++)
//        {
//            // Track number of elements swapped during a single array traversal
//            int numberOfSwaps = 0;

//            for (int j = 0; j < n - 1; j++)
//            {
//                // Swap adjacent elements if they are in decreasing order
//                if (a[j] > a[j + 1])
//                {
//                    temp = a[j];
//                    a[j] = a[j + 1];
//                    a[j + 1] = temp;
//                    numberOfSwaps++;
//                }
//            }

//            totalNumberOfSwaps += numberOfSwaps;

//            // If no elements were swapped during a traversal, array is sorted
//            if (numberOfSwaps == 0)
//            {
//                Console.WriteLine(totalNumberOfSwaps);
//                Console.WriteLine(a[0]);
//                Console.WriteLine(a[n-1]);
//                break;
//            }
//        }

//    }



//}
//*/



///*
//using System;
//class Solution
//{
//    static void Main(String[] args)
//    {
//        int value;
//        string line;

//        int numberOfTestCases;
//        numberOfTestCases = Convert.ToInt32(Console.ReadLine());
//        line = Console.ReadLine();
//        string[] bits;
//        int n;
//        int m;


//        while (line != null)
//        {
//            bits = line.Split(' ');
//            n = int.Parse(bits[0]);
//            m = int.Parse(bits[1]);

//            if (m == 1 || n % 2 == 0)
//                System.Console.WriteLine(2);
//            else
//                System.Console.WriteLine(1);

//            line = Console.ReadLine();
//        }
//    }
//}
//*/

///*
//using System;
//class Solution
//{
//    static void Main(String[] args)
//    {
//        int value;
//        string line;

//        int numberOfTestCases;
//        numberOfTestCases = Convert.ToInt32(Console.ReadLine());
//        line = Console.ReadLine();

//        while (line != null)
//        {
//            value = Convert.ToInt32(line);

//            PlayGameofStones(value);
//            line = Console.ReadLine();
//        }

//    }

//    static void PlayGameofStones(int stonesAvailable)
//    {

//        string winner;

//        if (stonesAvailable % 7 > 1)
//            winner = "First";
//        else
//            winner = "Second";

//        System.Console.WriteLine(winner);
//    }


//}

//*/

///*
//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//class Solution
//{
//    static int sum(int[] numbers)
//{

//        int sum = 0;
//        for (int i = 0; i < numbers.Length; i++)
//            sum += numbers[i];

//        return sum;
//}
//*/
///*
//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//class Solution
//{

//static void StairCase(int n)
//{
//    for (int i = 1; i <= n; i++)
//    {
//            for (int l = n; l >= 1; l--)
//            {
//                if (l <= i)
//                    System.Console.Write("#");
//                else
//                    System.Console.Write(" ");
//            }
//            System.Console.WriteLine("");
//    }

//}

//    static void Main(String[] args)
//    {
//        int _n;
//        _n = 5;

//        StairCase(_n);

//    }
//}
//*/

///*
//using System;
//using System.Collections.Generic;

//public class Worker : IDisposable
//{
//    private List<string> tasks = new List<string>();

//    public int Id { get; private set; }

//    public IEnumerable<string> Tasks { get { return this.tasks; } }

//    public Worker(int id)
//    {
//        this.Id = id;
//    }

//    public void PerformTask(string task)
//    {
//        if (this.tasks == null)
//            throw new ObjectDisposedException(this.GetType().Name);

//        this.tasks.Add(task);
//    }

//    public void Dispose()
//    {
//        this.tasks = null;
//        GC.SuppressFinalize(this);
//    }
//}

//public class Dispatcher
//{
//    private readonly Dictionary<int, Worker> workers = new Dictionary<int, Worker>();

//    public IEnumerable<Worker> Workers { get { return this.workers.Values; } }

//    public Worker AcquireWorker(int id)
//    {
//        Worker w = null;
//        if (!this.workers.TryGetValue(id, out w))
//        {
//            w = new Worker(id);
//            this.workers.Add(id, w);
//        }

//        return w;
//    }

//    public void ReleaseWorker(int id)
//    {
//        Worker w = null;
//        if (!this.workers.TryGetValue(id, out w))
//            throw new ArgumentException();
//        this.workers.Remove(id);
//        w.Dispose();
//    }

//    public static void Main(string[] args)
//    {
//        var d = new Dispatcher();

//        d.AcquireWorker(1).PerformTask("Task11");
//        d.AcquireWorker(2).PerformTask("Task21");
//        Console.WriteLine(string.Join(", ", d.AcquireWorker(2).Tasks));
//        d.ReleaseWorker(2);
//        d.AcquireWorker(1).PerformTask("Task12");
//        Console.WriteLine(string.Join(", ", d.AcquireWorker(1).Tasks));
//        d.ReleaseWorker(1);

//        d.AcquireWorker(1).PerformTask("Task11");
//        d.AcquireWorker(2).PerformTask("Task21");
//        Console.WriteLine(string.Join(", ", d.AcquireWorker(2).Tasks));
//        d.ReleaseWorker(2);
//        d.AcquireWorker(1).PerformTask("Task12");
//        Console.WriteLine(string.Join(", ", d.AcquireWorker(1).Tasks));
//        d.ReleaseWorker(1);

//        d.AcquireWorker(1).PerformTask("Task11");
//        d.AcquireWorker(2).PerformTask("Task21");
//        Console.WriteLine(string.Join(", ", d.AcquireWorker(2).Tasks));
//        d.ReleaseWorker(2);
//        d.AcquireWorker(1).PerformTask("Task12");
//        Console.WriteLine(string.Join(", ", d.AcquireWorker(1).Tasks));
//        d.ReleaseWorker(1);
//    }
//}
//*/

///*
//using System;
//using System.Collections.Generic;
//using System.Text.RegularExpressions;

//public class Trojan
//{
//    static List<string> list = new List<string>();

//    public static int CountCompromised(string xml, string infectedFileId)
//    {

//        string[] substrings = Regex.Split(xml, "folder>");
//        for(int i=0; i< substrings.Length;i++)
//        {

//            string pattern = "<file fileId=\"" +infectedFileId;
//             Match matchInfected = Regex.Match(substrings[i], pattern);

//            string infected = "<file fileId=\"(.*?>)";

//            if(matchInfected.Success)
//            { 
//                substrings[i] = Regex.Replace(substrings[i], pattern, "");
//                Match match = Regex.Match(substrings[i], infected);

//                while (match.Success)
//                {
//                    AddNewElemToList(match.Value);
//                    match.NextMatch();
//                    substrings[i] = Regex.Replace(substrings[i], match.Value, "");
//                    match = Regex.Match(substrings[i], infected);

//                }

//            }
//        }

//        // throw new NotImplementedException("Waiting to be implemented.");
//        return list.Count;
//    }


//    public static void AddNewElemToList(string elem)
//    {
//        if (!list.Contains(elem))
//            list.Add(elem);
//    }




//    static void Main(string[] args)
//    {
//        string xml =
//            "<?xml version=\"1.0\" encoding=\"UTF-8\"?>" +
//            "<root>" +
//            "   <snapshot>" +
//            "      <folder>" +
//            "         <file fileId=\"1\"/>" +
//            "         <file fileId=\"2\"/>" +
//            "         <folder>" +
//            "            <file fileId=\"3\"/>" +
//            "            <file fileId=\"4\"/>" +
//            "         </folder>" +
//            "      </folder>" +
//            "   </snapshot>" +
//            "   <snapshot>" +
//            "      <file fileId=\"1\"/>" +
//            "      <file fileId=\"3\"/>" +
//            "      <folder>" +
//            "         <file fileId=\"2\"/>" +
//            "         <file fileId=\"4\"/>" +
//            "         <folder>" +
//            "            <file fileId=\"3\"/>" +
//            "            <file fileId=\"4\"/>" +
//            "         </folder>" +
//            "      </folder>" +
//            "   </snapshot>" +
//            "</root>";

//        Console.WriteLine(Trojan.CountCompromised(xml, "3"));
//    }
//}*/

///*
//using System;
//using System.Collections.Generic;

//public class Grasshopper
//{
//    List<int> list = new List<int>();
//    static int currentPos = 0;
//    static int currentPosIndex = 0;
//    /// <summary>
//    /// Initialization of view field with n leaves and grasshopper on leaf 'position'.
//    /// </summary>
//    /// <param name="n">Number of leaves in row.</param>
//    /// <param name="position">Position.</param>
//    public Grasshopper(int n, int position)
//    {
//        currentPos = position;

//        for (int i = 1; i<= n;i++)
//        {
//            list.Add(i);

//        }
//        currentPosIndex = list.IndexOf(position);
//    }

//    /// <summary>
//    /// Grasshopper has eaten the current leaf and hopped left.
//    /// </summary>
//    public void EatAndHopLeft()
//    {
//        int eat = currentPos;
//        currentPos = list[currentPosIndex - 2];

//        list.Remove(eat);
//        currentPosIndex = list.IndexOf(currentPos);

//    }

//    /// <summary>
//    /// Grasshopper has eaten the current leaf and hopped right.
//    /// </summary>
//    public void EatAndHopRight()
//    {
//        int eat = currentPos;
//        currentPos = list[currentPosIndex + 2];
//        list.Remove(eat);
//        currentPosIndex = list.IndexOf(currentPos);
//    }

//    /// <returns>Leaf number that grasshopper is feeding on right now.</returns>
//    public int WhereAmI()
//    {
//        return currentPos;
//        //throw new InvalidOperationException("Waiting to be implemented.");
//    }

//    public static void Main(string[] args)
//    {
//        Grasshopper g = new Grasshopper(10, 2);
//        Console.WriteLine(g.WhereAmI());

//        g.EatAndHopRight();
//        Console.WriteLine(g.WhereAmI());

//        g.EatAndHopLeft();
//        Console.WriteLine(g.WhereAmI());

//        g.EatAndHopRight();
//        Console.WriteLine(g.WhereAmI());

//        g.EatAndHopRight();
//        Console.WriteLine(g.WhereAmI());

//        g.EatAndHopRight();
//        Console.WriteLine(g.WhereAmI());
//    }
//}
//*/
///*
//using System;
//using System.Text.RegularExpressions;

//public class Paragraph
//{
//    public static string ChangeDateFormat(string paragraph)
//    {
//        return Regex.Replace(paragraph,
//            "\\b(?<month>\\d{1,2})/(?<day>\\d{1,2})/(?<year>\\d{2,4})\\b",
//            "${day}/${month}/${year}", RegexOptions.None,
//            TimeSpan.FromMilliseconds(150));
//        // throw new InvalidOperationException("Waiting to be implemented.");
//    }

//    public static void Main(string[] args)
//    {
//        Console.WriteLine(ChangeDateFormat("Last time it rained was on 07/25/2013 and today is 08/09/2013."));
//    }
//}
//*/

////BSM Validation
///*
//using System;

//public class Node
//{
//    public int Value { get; set; }

//    public Node Left { get; set; }

//    public Node Right { get; set; }

//    public Node(int value, Node left, Node right)
//    {
//        Value = value;
//        Left = left;
//        Right = right;
//    }
//}

//public class BinarySearchTree
//{

//    public static bool IsValidBST(Node root)
//    {
//        return isValidBST(root, int.MinValue,
//             int.MaxValue);
//    }
//    private static bool isValidBST(Node node, int MIN, int MAX)
//    {
//        if (node == null)
//            return true;
//        if (node.Value > MIN
//            && node.Value <= MAX
//            && isValidBST(node.Left, MIN, node.Value)
//            && isValidBST(node.Right, node.Value, MAX))
//            return true;
//        else
//            return false;
//    }


//    public static void Main(string[] args)
//    {
//        Node n1 = new Node(1, null, null);
//        Node n3 = new Node(3, null, null);
//        Node n2 = new Node(2, n1, n3);

//        Console.WriteLine(IsValidBST(n2));
//    }
//}
//*/


///*
//using System;

//public class SortedSearch
//{
//    static int count;
//    public static int CountNumbers(int[] sortedArray, int lessThan)
//    {
//        count = 0;


//        int mid = 0, first = 0, last = sortedArray.Length - 1;


//        while ( first <= last)
//        {
//            mid = (first + last) / 2;

//            if (sortedArray[mid] < lessThan && sortedArray[mid + 1] >= lessThan)
//                return mid + 1;
//            { 

//                if (sortedArray[mid] > lessThan)
//                {
//                    last = mid - 1;
//                }

//                if ( sortedArray[mid] < lessThan )
//                {
//                    first = mid + 1;
//                }

//            }

//        }

//        return count;
//    }

//    public static void Main(string[] args)
//    {
//        Console.WriteLine(SortedSearch.CountNumbers(new int[] { 1, 1,1,1,1,1,1,1,1,1,1,1,3, 5, 7 }, 4));
//    }
//}

//*/



///*using System;

//public class PalindromeSimple
//{
//    public static bool IsPalindrome(string word)
//    {
//        char[] array = word.ToCharArray();
//        char min = word[0];
//        char max = word [word.Length -1];

//        for(int i=0; i<word.Length/2;i++)
//        {
//            if (char.ToLower(min) == char.ToLower(max))
//            {
//                min = word[i+1];
//                max = word[word.Length - (i+2)];
//            }
//            else
//                return false;
//        }


//        return true;
//    }

//    public static void Main(string[] args)
//    {
//        Console.WriteLine(PalindromeSimple.IsPalindrome("Deleveled"));
//    }
//}
//*/
////Longest run
///*
//using System;

//public class Run
//{
//    public static int IndexOfLongestRun(string str)
//    {
//        int longestRunIndex = 0;
//        int longestRunValue = 0;
//        int currentRun = 0;
//        //char temp;
//        //char current;
//        char[] array = str.ToCharArray();
//        char temp = array[0];
//        for (int i = 0; i < str.Length; i++)
//        {
//            if (temp == array[i])
//                currentRun++;
//            else
//            {
//                currentRun = 1;
//                temp = array[i];
//            }

//            if (currentRun > longestRunValue)
//            {
//                longestRunValue = currentRun;
//                longestRunIndex = i - currentRun + 1;
//            }
//        }
//        return longestRunIndex; 
//    }

//    public static void Main(string[] args)
//    {
//        Console.WriteLine(IndexOfLongestRun("abbcccddddcccbba"));
//    }
//}
//*/
////All anagrams
///*
//using System;
//using System.Collections.Generic;

//public class AllAnagrams
//{


//    static ICollection<string> result;


//    public static ICollection<string> GetAllAnagrams(string str)
//    {
//        result = new List<string>();
//        //ICollection<string> col = new List<string>();
//        GetPer(str);
//        // throw new NotImplementedException("Waiting to be implemented.");
//        return result;
//    }

//    static string SwapCharacters(string str, int position1, int position2)
//    {
//        if (str[position1] == str[position2]) return str;

//        //
//        // Swaps characters in a string. Must copy the characters and reallocate the string.
//        //
//        char[] array = str.ToCharArray(); // Get characters
//        char temp = array[position1]; // Get temporary copy of character
//        array[position1] = array[position2]; // Assign element
//        array[position2] = temp; // Assign element
//        return new string(array); // Return string
//    }

//    public static void GetPer(string str)
//    {
//        int x = str.Length - 1;
//        GetPer(str, 0, x);
//    }

//    private static void GetPer(string list, int k, int m)
//    {

//        if (k == m)
//        {
//           if (!result.Contains(list))
//                result.Add(list);

//        }
//        else
//            for (int i = k; i <= m; i++)
//            {

//                list = SwapCharacters(list, k, i);
//                GetPer(list, k + 1, m);
//                list = SwapCharacters(list, k, i);
//            }
//    }


//    public static void Main(string[] args)
//    {
//        ICollection<string> anagrams = GetAllAnagrams("abba");

//        foreach (string a in anagrams)
//            Console.WriteLine(a);
//    }
//}


//*/

///*
//public static class LongestRunIndex
//{
//    public static Int32 IndexOfLongestRun(this String value)
//    {
//        var currentRunLength = 0;
//        var currentRunIndex = 0;

//        var longestRunLength = 0;
//        var longestRunIndex = 0;

//        for (var i = 1; i < value.Length; i++)
//        {
//            var currentCharacter = value[i];
//            var previousCharacter = value[i - 1];

//            if (previousCharacter == currentCharacter)
//            {
//                currentRunLength++;
//            }
//            else
//            {
//                if (longestRunLength < currentRunLength)
//                {
//                    longestRunLength = currentRunLength;
//                    longestRunIndex = currentRunIndex;
//                }

//                currentRunLength = 0;
//                currentRunIndex = i;
//            }
//        }

//        if (longestRunLength < currentRunLength)
//        {
//            longestRunLength = currentRunLength;
//            longestRunIndex = currentRunIndex;
//        }

//        return longestRunIndex;
//    }
//}
//*/

/////Are Anagrams
///* 
//using System;
//public class AreAnagrams
//{
//    public static bool AreStringsAnagrams(string a, string b)
//    {
//        if (string.IsNullOrEmpty(a) || string.IsNullOrEmpty(b) || (a.Length != b.Length)) return false;

//        foreach (char c in b)
//        {
//            int i = a.IndexOf(c);
//            if (i >= 0) a = a.Remove(i, 1);
//            else return false;
//        }
//        return string.IsNullOrEmpty(a);
//    }

//    public static void Main(string[] args)
//    {
//        Console.WriteLine(AreStringsAnagrams("momdad", "dadmom"));
//    }
//}
//*/
////Frog Permutations Number of Ways
///*
//using System;

//using System.Collections.Generic;


//public class Frog
//{
//    public static int NumberOfWays(int n)
//    {
//        return NoOfPermutaions(NoOfCombinations(n));
//    }

//    private static List<Tuple<int, int>> NoOfCombinations(int distance)
//    {
//        List<Tuple<int, int>> lst = new List<Tuple<int, int>>();
//        for (int i = 0; i <= distance; i++)
//            for (int j = 0; j <= distance; j++)
//            {
//                if ((i * 1 + j * 2) == distance) lst.Add(new Tuple<int, int>(i, j));
//            }
//        return lst;
//    }

//    private static int NoOfPermutaions(List<Tuple<int, int>> lst)
//    {
//        int Sum = 0;
//        foreach (Tuple<int, int> itm in lst)
//        {
//            Sum += Convert.ToInt32(Factorial(itm.Item1 + itm.Item2) / Factorial(itm.Item1) / Factorial(itm.Item2)); //Formula: C(n,r)=n!/r!;
//        }

//        return Sum;
//    }

//    private static double Factorial(double num)
//    {
//        if (num <= 1)
//            return 1;
//        return num * Factorial(num - 1);
//    }

//    public static void Main(String[] args)
//    {
//        Console.WriteLine(NumberOfWays(3));
//    }
//}

//*/

/////Is Palidrome
///*
//using System;

//public class PalindromeSimple
//{
//    public static bool IsPalindrome(string word)
//    {
//        int min = 0;
//        int max = word.Length - 1;

//        while (true)
//        {
//            if (min > max)
//            {
//                return true;
//            }
//            //Check the extremes of the word
//            char a = word[min];
//            char b = word[max];
//            //make it not case sensitive
//            if (char.ToLower(a) != char.ToLower(b))
//            {
//                return false;
//            }
//            //go for the next position
//            min++;
//            max--;
//        }
//    }

//    public static void Main(string[] args)
//    {
//        Console.WriteLine(PalindromeSimple.IsPalindrome("Deleveled"));
//    }
//}

//*/




///// Two Sum
///*using System;
//using System.Collections.Generic;

//class TwoSum
//{
//    public static Tuple<int, int> FindTwoSum(IList<int> list, int sum)
//    {

//        if (list == null)
//            return null;

//        // constructing a hashset to have O(1) operations
//        var listSet = new HashSet<int>();

//        // number -> index mapping
//        // O(n) complexity
//        var listReverseSet = new Dictionary<int, int>();
//        int i = 0;
//        foreach (var elem in list)
//        {
//            if (!listSet.Contains(elem))
//                listSet.Add(elem);

//            listReverseSet[elem] = i++;
//        }

//        // O(n) complexity
//        int listCount = list.Count;
//        for (int index = 0; index < listCount; index++)
//        {
//            var elem = list[index];

//            if (listSet.Contains(sum - elem))
//                return new Tuple<int, int>(index, listReverseSet[sum - elem]);
//        }

//        return null;



//    }

//    public static void Main(string[] args)
//    {
//        Tuple<int, int> indices = FindTwoSum(new List<int>() { 1, 3, 5, 7, 9 }, 12);
//        Console.WriteLine(indices.Item1 + " " + indices.Item2);
//    }
//}
//*/
