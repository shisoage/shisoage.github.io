using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Asobi
{
    public static void Main()
    {
        Asobi asobi = new Asobi();
        Random rand = new Random();

        //入れたキーを所得(必要なし）
        //ConsoleKeyInfo keypressded = Console.ReadKey();
        //Console.WriteLine(keypressded.Key.ToString());
        //ConsoleKeyInfo houkou = Console.ReadKey(true);
        //var test = new List<string>();
        //test.Add("okome");
        //test.Add("sanshou");
        //test.Add("udon");
        //test.Add("mentaiko");
        //int testnumber = 0;
        //Console.WriteLine(test[testnumber]);



        //-----------------------プレイヤー最初期設定---------------------//

        int playerAtk = 5;
        int playerHP = 10;
        int playerMgk = 3;

        //-----------------------プレイヤー最初期設定---------------------//


        Console.WriteLine("おや、君が新しい従業員くんか▼");
        Console.Read();
        Console.WriteLine("君の名前を教えてくれ");
        Thread.Sleep(1000);
        Console.Write("名前： ");
        bool nameChoose = true;
        string name = "";
        while (nameChoose)
        {
            name = Console.ReadLine();
            if (name != "")
            {
                nameChoose = false;
            }
            else { }
        }
        Console.WriteLine(name + "くん、か。いい名前じゃないか▼");
        Console.Read();
        Console.WriteLine("突然ですまないが、まずはあれを倒してくれないか▼");
        Console.Read();
        playerHP = asobi.blueSlime(playerHP, playerAtk, playerMgk/*rand.Next(1, 16)*/);
        Console.WriteLine("なるほど…ありがとう。\n改めて、ようこそ▼");
        Console.Read();
        Console.Write("みやの雑貨店へ");
        Thread.Sleep(1000);
        Console.Write(".");
        Thread.Sleep(500);
        Console.Write(".");
        Thread.Sleep(500);
        Console.Write(".");
        Thread.Sleep(500);
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Thread.Sleep(1000);

        //Console.WriteLine(playerHP);
        //Console.Read();
        
        Console.WriteLine("第一章：創生の本▼");
        Console.Read();

        playerHP = 20;

        //-----------------------武器選択----------------------//
        var weapon = new List<string>();
        var weaponSlot = new List<string>();
        var item = new List<string>();
        var itemslot = new List<string>();

        Console.WriteLine("ペーパーナイフを手に入れた▼");
        weapon.Add("ペーパーナイフ");
        Console.ReadLine();
        Console.Write("ペーパーナイフ：");
        Console.WriteLine("紙を切るためのナイフ。刃はなく、子供でも扱いやすい");
        Thread.Sleep(800);
        Console.WriteLine("攻撃力 + 2");
        Console.ReadLine();

       

        //weapon.Add("だいこん");
        //weapon.Add("ソーセージ");
        //weapon.Add("星街すいせい");

        Console.Write("武器：　");
        bool choosing = true;
        int stopOverflow = weapon.Count - 1;
        int weaponNumber = 0;
        


        Console.WriteLine(weapon[weaponNumber]);
        while (choosing)
        {
            ConsoleKeyInfo choose = Console.ReadKey();
            if (choose.Key.ToString() == "UpArrow")
            {
                weaponNumber++;
                if (weaponNumber > stopOverflow)
                {
                    weaponNumber = 0;
                }
                else { }
                Console.WriteLine(weapon[weaponNumber]);
            }
            else if (choose.Key.ToString() == "DownArrow")
            {
                weaponNumber--;
                if (weaponNumber < 0)
                {
                    weaponNumber = stopOverflow;
                }
                else { }
                Console.WriteLine(weapon[weaponNumber]);
            }
            else if (choose.Key.ToString() == "Enter")
            {
                weaponSlot.Add(weapon[weaponNumber]);
                choosing = false;
                Console.WriteLine();
            }
            else { }
            

        }
        
        foreach (string i in weaponSlot)
        {
            Console.Write(i);
        }
        //-----------------------武器選択----------------------//




        //-----------------持ち物検査---------------//

        //----武器--//
        if (weaponSlot.Contains("ペーパーナイフ"))
        {
            playerAtk = playerAtk + 2;
        }

        else
        {

        }
        //----武器----//
        //----アイテム----/
        if (itemslot.Contains(""))
        {

        }

        else
        {

        }
        //----アイテム----//

        //-----------------持ち物検査---------------//

        


        bool bouken = true;
        
        while (bouken)
        {
            string basho1 = asobi._Basho("trigger");
            string basho2 = asobi._Basho("trigger");
            string basho3 = asobi._Basho("trigger");

            here:
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("     ↑" + basho1 + "↑     ");
            Console.WriteLine();
            Console.WriteLine("←" + basho2 + "        " + basho3 + "→");
            Console.WriteLine("Menu: Enter");
            ConsoleKeyInfo houkou = Console.ReadKey();

            int nextEvent = rand.Next(0,8);



            if (houkou.Key.ToString() == "W" || houkou.Key.ToString() == "UpArrow")
            {
                if (basho1 == "草")
                {
                    switch (nextEvent)
                    {
                        case 0:
                        case 1:
                        case 2:
                            playerHP = asobi.kemujara(playerHP, playerAtk, playerMgk);
                            Console.WriteLine();
                            Console.Read();

                            break;
                        case 3:
                        case 4:
                            playerHP = asobi.dekaihachi(playerHP, playerAtk, playerMgk);
                            Console.WriteLine();
                            Thread.Sleep(1000);
                            break;
                        default:
                            Console.WriteLine("そよ風がここちいい");
                            Console.WriteLine();
                            Console.Read();
                            break;
                    }
                }
                else if (basho1 == "泥")
                {
                    switch (nextEvent)
                    {
                        case 0:
                        case 1:
                            playerHP = asobi.kemujara(playerHP, playerAtk, playerMgk);
                            Console.WriteLine();
                            Console.Read();

                            break;
                        case 2:
                        case 3:
                        case 4:
                        case 5:
                            playerHP = asobi.dekaihachi(playerHP, playerAtk, playerMgk);
                            Console.WriteLine();
                            Thread.Sleep(1000);
                            break;
                        default:
                            Console.WriteLine("泥人形でもつくろうかな…");
                            Console.WriteLine();
                            Console.Read();
                            break;
                    }
                }
                else if (basho1 == "道")
                {
                    switch (nextEvent)
                    {
                        case 0:
                            playerHP = asobi.kemujara(playerHP, playerAtk, playerMgk);
                            Console.WriteLine();
                            Console.Read();
                            break;
                        case 2:
                            playerHP = asobi.dekaihachi(playerHP, playerAtk, playerMgk);
                            Console.WriteLine();
                            Thread.Sleep(1000);
                            break;
                        default:
                            Console.WriteLine("しっかりと整備されている");
                            Console.WriteLine();
                            Thread.Sleep(1000);
                            break;
                    }
                }
                else if (basho1 == "水辺")
                {
                    switch (nextEvent)
                    {
                        case 0:
                        case 1:
                        case 2:
                        case 3:
                            playerHP = asobi.kemujara(playerHP, playerAtk, playerMgk);
                            Console.WriteLine();
                            Console.Read();
                            break;
                        case 4:
                        case 5:
                        case 6:
                            playerHP = asobi.dekaihachi(playerHP, playerAtk, playerMgk);
                            Console.WriteLine();
                            Thread.Sleep(1000);
                            break;
                        default:
                            Console.WriteLine("水は透き通るようにきれいだ");
                            Console.WriteLine();
                            Console.Read();
                            break;
                    }
                }
                Thread.Sleep(2000);
            }
            else if (houkou.Key.ToString() == "A" || houkou.Key.ToString() == "LeftArrow")
            {

            }
            else if (houkou.Key.ToString() == "S" || houkou.Key.ToString() == "DownArrow")
            {

            }
            else if (houkou.Key.ToString() == "D" || houkou.Key.ToString() == "RightArrow")
            {

            }


            else if (houkou.Key.ToString() == "Enter")
            {
                Boolean menu = true;
                while (menu)
                {
                    here2:
                    Console.WriteLine("1.装備");
                    Console.WriteLine("2.ステータス");
                    Console.WriteLine("3.アイテム");
                    ConsoleKeyInfo menuChoice = Console.ReadKey();
                    Console.WriteLine();

                    if (menuChoice.Key.ToString() == "D1")
                    {
                        Console.Write("武器： ");
                        foreach (string i in weaponSlot)
                        {
                            Console.Write(i + " ");
                        }
                        Console.WriteLine();
                    }
                    else if (menuChoice.Key.ToString() == "D2")
                    {
                        Console.WriteLine("ちから：" + playerAtk);
                        Console.WriteLine("まほう：" + playerMgk);
                        Console.WriteLine("HP：" + playerHP);
                        Console.WriteLine();
                    }
                    else if (menuChoice.Key.ToString() == "D3")
                    {
                        Console.Write(" アイテム： ");
                        foreach (string i in itemslot)
                        {
                            Console.Write(i + " ");
                        }
                        Console.WriteLine();
                    }
                    else if (menuChoice.Key.ToString() == "Enter")
                    {
                        Console.WriteLine();
                        goto here;
                    }
                    else
                    {
                        Console.WriteLine();
                        goto here2;
                    }
                }
                
            }
            else
            {
                Console.WriteLine();
                goto here;
            }
        }

        Console.ReadLine();




        /*本系
        武器（ペーパーナイフとか）
        ペン*/
        //エレベーター→ボタンが一個しかない、行きたい場所の階を思いながら押すといける
        //店長しか扱えなかったり？？
        //冒険の前に持っていくものや装備全部選ぶ式にしよ
        }
    







    string _Basho(string bashou)
    {
        Random rand = new Random();
        int basho = rand.Next(0, 4);
        string basho1 = "";

        if (basho == 0)
        {
            basho1 = "草";
        }
        else if (basho == 1)
        {
            basho1 = "道";
        }
        else if (basho == 2)
        {
            basho1 = "泥";
        }
        else if (basho == 3)
        {
            basho1 = "水辺";
        }
        else
        {
            Console.WriteLine("ばかがデバックしろ");
        }
        return basho1;
    }





    //--------------------コドモトリ処理---------------------//

    int kodomotori(int playerHP, int playerAtk, int playerMgk)
    {
        Console.WriteLine();
        Console.WriteLine();
        Thread.Sleep(1000);
        Random rand = new Random();
        int enemyHP = 15;
        Console.WriteLine("また新たな敵だ");
        Console.WriteLine("コドモトリが現れた");
        Thread.Sleep(500);

        while (enemyHP > 0)
        {
            int serifu = rand.Next(1, 101);
            if (serifu <= 45)
            {
                Console.WriteLine("コドモトリはキョロキョロしている");
            }
            else if (serifu >= 46 && serifu <= 90)
            {
                Console.WriteLine("コドモトリは落ち着きがない");
            }
            else
            {
                Console.WriteLine("最近もコドモトリの誘拐事件があったような");
            }
            Console.WriteLine("Attack / Magic / Info");
            string move = Console.ReadLine().ToLower();
            Thread.Sleep(1000);

            if (move == "attack")
            {
                int damageDone = rand.Next((playerAtk - 1), (playerAtk + 4));
                //blueSlime(damageDone, hp);
                enemyHP = enemyHP - damageDone;
                Console.WriteLine("コドモトリに" + damageDone + "ダメージ");
                if (enemyHP > 0)
                {
                    Console.WriteLine("残り" + enemyHP + "HPだ");
                }
                else if (enemyHP <= 0)
                {
                    Console.WriteLine("コドモトリを倒した");
                    Thread.Sleep(1000);
                    break;
                }

                Thread.Sleep(1000);
            }

            else if (move == "magic")
            {
                int damageDone = rand.Next((playerMgk - 2), (playerMgk + 6));
                enemyHP = enemyHP - damageDone;
                Console.WriteLine("コドモトリに" + damageDone + "ダメージ");
                if (enemyHP > 0)
                {
                    Console.WriteLine("残り" + enemyHP + "HPだ");
                }
                else if (enemyHP <= 0)
                {
                    Console.WriteLine("コドモトリを倒した");
                    Thread.Sleep(1000);
                    break;
                }
            }

            else if (move == "info")
            {
                Console.WriteLine("コドモトリ：");
                Console.WriteLine("子供をさらっては自分の巣から繋がっている異次元へと誘う猿型の魔物");
                Console.WriteLine("助け出した子供たちはみんなボロボロの場合が多い。");
                Console.WriteLine("人を襲うことはあまりないが、食べ物などを盗んでいくため");
                Console.WriteLine("特別駆除対象生物に設定されている");
                Console.WriteLine("HP: " + enemyHP + "/15");
                Console.WriteLine("攻撃力：1");
                Console.ReadLine();
                continue;
            }

            else
            {
                Console.WriteLine();
                continue;
            }
            int damageTook = rand.Next(1,2);

            Console.WriteLine("コドモトリの攻撃");
            Thread.Sleep(1000);
            Console.WriteLine("君に" + damageTook + "ダメージ");
            Thread.Sleep(1000);
            playerHP = playerHP - damageTook;


            if (playerHP <= 0)
            {
                Console.WriteLine("目の前に星が飛んでいる");
                Thread.Sleep(1000);
                Console.WriteLine();
                Console.WriteLine("おしまい");
                Console.ReadLine();
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("君のHPはあと" + playerHP + "HPだ");
                Console.WriteLine();
            }


        }
        Thread.Sleep(2000);
        return playerHP;

    }

    //--------------------コドモトリ処理---------------------//




    //--------------------でかいはち処理---------------------//

    int dekaihachi(int playerHP, int playerAtk, int playerMgk)
    {
        Console.WriteLine();
        Console.WriteLine();
        Thread.Sleep(1000);
        Random rand = new Random();
        int enemyHP = 15;
        Console.WriteLine("また新たな敵だ");
        Console.WriteLine("でかいはちが現れた");
        Thread.Sleep(500);
        
        while (enemyHP > 0)
        {
            int serifu = rand.Next(1, 101);
            if (serifu <= 45)
            {
                Console.WriteLine("でかいはちはぶるんぶるんと羽を鳴らしている");
            }
            else if (serifu >= 46 && serifu <= 90)
            {
                Console.WriteLine("でかいはちの鋭い針が光る");
            }
            else
            {
                Console.WriteLine("でかいはちは無機質な目でこちらを見ている");
            }
            Console.WriteLine("Attack / Magic / Info");
            string move = Console.ReadLine().ToLower();
            Thread.Sleep(1000);

            if (move == "attack")
            {
                int damageDone = rand.Next((playerAtk - 1), (playerAtk + 4));
                //blueSlime(damageDone, hp);
                enemyHP = enemyHP - damageDone;
                Console.WriteLine("でかいはちに" + damageDone + "ダメージ");
                if (enemyHP > 0)
                {
                    Console.WriteLine("残り" + enemyHP + "HPだ");
                }
                else if (enemyHP <= 0)
                {
                    Console.WriteLine("でかいはちを倒した");
                    Thread.Sleep(1000);
                    break;
                }

                Thread.Sleep(1000);
            }

            else if (move == "magic")
            {
                int damageDone = rand.Next((playerMgk - 2), (playerMgk + 6));
                enemyHP = enemyHP - damageDone;
                Console.WriteLine("でかいはちに" + damageDone + "ダメージ");
                if (enemyHP > 0)
                {
                    Console.WriteLine("残り" + enemyHP + "HPだ");
                }
                else if (enemyHP <= 0)
                {
                    Console.WriteLine("でかいはちを倒した");
                    Thread.Sleep(1000);
                    break;
                }
            }

            else if (move == "info")
            {
                Console.WriteLine("でかいはち：");
                Console.WriteLine("けっこうでかいはち。よくよく見ると所々が機械でできている。");
                Console.WriteLine("攻撃しない限り襲ってくることは少ないが巣が近くにあると話は別。");
                Console.WriteLine("その鋭い針で刺してくる。当たりどころが悪いと死に至ることも");
                Console.WriteLine("HP: " + enemyHP + "/15");
                Console.WriteLine("攻撃力：4");
                Console.ReadLine();
                continue;
            }

            else
            {
                Console.WriteLine();
                continue;
            }
            int damageTook = rand.Next(2, 7);

            Console.WriteLine("でかいはちの攻撃");
            Thread.Sleep(1000);
            Console.WriteLine("君に" + damageTook + "ダメージ");
            Thread.Sleep(1000);
            playerHP = playerHP - damageTook;


            if (playerHP <= 0)
            {
                Console.WriteLine("目の前がまっかになった");
                Thread.Sleep(1000);
                Console.WriteLine();
                Console.WriteLine("おしまい");
                Console.ReadLine();
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("君のHPはあと" + playerHP + "HPだ");
                Console.WriteLine();
            }


        }
        Thread.Sleep(2000);
        return playerHP;

    }

    //--------------------でかいはち処理---------------------//




    //--------------------けむくじゃら処理---------------------//

    int kemujara(int playerHP, int playerAtk, int playerMgk)
    {

        Console.WriteLine();
        Console.WriteLine();
        Thread.Sleep(1000);
        Random rand = new Random();
        int enemyHP = 30;
        Console.WriteLine("また新たな敵だ");
        Console.WriteLine("けむくじゃらが現れた");
        Thread.Sleep(500);

        while (enemyHP > 0)
        {
            int serifu = rand.Next(1, 101);
            if (serifu <= 45)
            {
                Console.WriteLine("けむくじゃらは毛を靡かせている");
            }
            else if (serifu >= 46 && serifu <= 90)
            {
                Console.WriteLine("けむくじゃらは楽しそうだ");
            }
            else
            {
                Console.WriteLine("けむくじゃらはまっすぐ君の頭を見ている");
            }
            Console.WriteLine("Attack / Magic / Info");
            string move = Console.ReadLine().ToLower();
            Thread.Sleep(1000);

            if (move == "attack")
            {
                int damageDone = rand.Next((playerAtk - 1), (playerAtk + 4));
                //blueSlime(damageDone, hp);
                enemyHP = enemyHP - damageDone;
                Console.WriteLine("けむくじゃらに" + damageDone + "ダメージ");
                if (enemyHP > 0)
                {
                    Console.WriteLine("残り" + enemyHP + "HPだ");
                }
                else if (enemyHP <= 0)
                {
                    Console.WriteLine("けむくじゃらを倒した");
                    Thread.Sleep(1000);
                    break;
                }

                Thread.Sleep(1000);
            }

            else if (move == "magic")
            {
                int damageDone = rand.Next((playerMgk - 2), (playerMgk + 6));
                enemyHP = enemyHP - damageDone;
                Console.WriteLine("けむくじゃらに" + damageDone + "ダメージ");
                if (enemyHP > 0)
                {
                    Console.WriteLine("残り" + enemyHP + "HPだ");
                }
                else if (enemyHP <= 0)
                {
                    Console.WriteLine("けむくじゃらを倒した");
                    Thread.Sleep(1000);
                    break;
                }
            }

            else if (move == "info") {
                Console.WriteLine("けむくじゃら：");
                Console.WriteLine("さまざまな毛の色や種類の個体がいる。");
                Console.WriteLine("たまに仲間同士で喧嘩をするがその時は決まって同じ見た目の" +
                    "もの同士。");
                Console.WriteLine("基本的には人間が好きで寄ってくるが、火を見ると一目散に逃げていく");
                Console.WriteLine("HP: " + enemyHP + "/30");
                Console.WriteLine("攻撃力：2");
                Console.ReadLine();
                continue;
            }

            else
            {
                Console.WriteLine();
                continue;
            }
            int damageTook = rand.Next(1, 4);

            Console.WriteLine("けむくじゃらの攻撃");
            Thread.Sleep(1000);
            Console.WriteLine("君に" + damageTook + "ダメージ");
            Thread.Sleep(1000);
            playerHP = playerHP - damageTook;


            if (playerHP <= 0)
            {
                Console.WriteLine("目の前がけだらけになった");
                Thread.Sleep(1000);
                Console.WriteLine();
                Console.WriteLine("おしまい");
                Console.ReadLine();
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("君のHPはあと" + playerHP + "HPだ");
                Console.WriteLine();
            }


        }
        Thread.Sleep(2000);
        return playerHP;
        
    }

    //--------------------けむくじゃら処理---------------------//






    //-------------------ブルースライム処理--------------------//
    int blueSlime(int playerHP, int playerAtk, int playerMgk)
    { 
        Random rand = new Random();
        int enemyHP = 10;
        Console.WriteLine("ブルースライムが現れた");
        Thread.Sleep(500);
        
        while (enemyHP > 0)
        {
            Console.WriteLine("Attack / Magic");
            string move = Console.ReadLine().ToLower();
            Thread.Sleep(1000);
            
            if (move == "attack")
            {
                int damageDone = rand.Next((playerAtk - 1), (playerAtk + 4));
                //blueSlime(damageDone, hp);
                enemyHP = enemyHP - damageDone;
                Console.WriteLine("ブルースライムに" + damageDone + "ダメージ");
                if (enemyHP > 0)
                {
                    Console.WriteLine("残り" + enemyHP + "HPだ");
                }
                else if (enemyHP <= 0)
                {
                    Console.WriteLine("ブルースライムを倒した");
                    Thread.Sleep(1000);
                    break;
                }

                Thread.Sleep(1000);
            }

            else if (move == "magic")
            {
                int damageDone = rand.Next((playerMgk - 2), (playerMgk + 6));
                enemyHP = enemyHP - damageDone;
                Console.WriteLine("ブルースライムに" + damageDone + "ダメージ");
                if (enemyHP > 0)
                {
                    Console.WriteLine("残り" + enemyHP + "HPだ");
                }
                else if (enemyHP <= 0)
                {
                    Console.WriteLine("ブルースライムを倒した");
                    Thread.Sleep(1000);
                    break;
                }
            }

            else
            {
                continue;
            }
            int damageTook = rand.Next(1, 4);

            Console.WriteLine("ブルースライムの攻撃");
            Thread.Sleep(1000);
            Console.WriteLine("君に" + damageTook + "ダメージ");
            Thread.Sleep(1000);
            playerHP = playerHP - damageTook;


            if (playerHP <= 0)
            {
                Console.WriteLine("目の前がまっさおになった");
                Thread.Sleep(1000);
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("君のHPはあと" + playerHP + "HPだ");
                Console.WriteLine();
            }


        }
        return playerHP;
        Thread.Sleep(2000);
    }
    //-------------------ブルースライム処理--------------------//
}