using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace kore
{
    public class Asobi
    {
        public string name = "";
        public static bool knife = false;
        public static bool book = false;
        public static void Main()
        {
            Asobi asobi = new Asobi();
            Random rand = new Random();
            Enemy enemy = new Enemy();
            Home home = new Home();
            Story1 story1 = new Story1();
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
            //Console.ForegroundColor = ConsoleColor.DarkRed;
            //Console.Write("testing ");
            //Console.ResetColor();
            //Console.WriteLine("end");
            //asobi.serifu("やかんだぁ");
            //var testitemholder = new List<string>();
            //asobi.itemHolder = "yakan";
            //testitemholder.Add(asobi.itemHolder);
            //asobi.itemHolder = "";
            //foreach (string i in testitemholder)
            //{
            //    asobi.serifu(i);
            //}

            //-----------------------プレイヤー最初期設定---------------------//

            int playerAtk = 4;
            int playerHP = 10;
            int playerMgk = 4;

            //-----------------------プレイヤー最初期設定---------------------//
            

            asobi.serifu("おや、君が新しい従業員くんか");
            asobi.noWaitSerifu("君の名前を教えてくれ");
            Thread.Sleep(100);
            Console.WriteLine();
            Console.Write("名前： ");
            bool nameChoose = true;
            while (nameChoose)
            {
                asobi.name = Console.ReadLine();
                if (asobi.name != "")
                {
                    nameChoose = false;
                }
                else { }
            }
            asobi.serifu(asobi.name + "くん、か。いい名前じゃないか");
            asobi.serifu("突然ですまないが、まずはあれを倒してくれないか");
            playerHP = asobi.blueSlime(playerHP, playerAtk, playerMgk/*rand.Next(1, 16)*/);
            asobi.serifu("なるほど...  ありがとう。\n改めて、ようこそ");
            asobi.noWaitSerifu("みやの雑貨店へ");
            Thread.Sleep(1000);
            Console.Write(".");
            Thread.Sleep(1500);
            Console.Write(".");
            Thread.Sleep(1500);
            Console.Write(".");
            Thread.Sleep(1500);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Thread.Sleep(1000);

            //Console.WriteLine(playerHP);
            //Console.Read();

            story1.hanashi1();
            playerHP = 20;



            //-----------------------武器選択----------------------//
            var weapon = new List<string>();
            var weaponSlot = new List<string>();
            var item = new List<string>();
            var itemslot = new List<string>();

            asobi.serifu("ペーパーナイフを手に入れた");
            weapon.Add("ペーパーナイフ");
            asobi.noWaitSerifu("ペーパーナイフ：");
            Console.WriteLine();
            asobi.noWaitSerifu("紙を切るためのナイフ。刃はなく、子供でも扱いやすい");
            Thread.Sleep(500);
            Console.WriteLine();
            asobi.serifu("攻撃力 + 2");

            asobi.serifu("徹底解説！はじめての魔法を手に入れた");
            weapon.Add("徹底解説！はじめての魔法");
            asobi.noWaitSerifu("徹底解説！はじめての魔法:");
            Console.WriteLine();
            asobi.noWaitSerifu("初心者ように書かれた簡単な魔法の扱い方が載ってる本");
            Thread.Sleep(500);
            Console.WriteLine();
            asobi.serifu("魔法力 + 2");


            //weapon.Add("だいこん");
            //weapon.Add("ソーセージ");
            //weapon.Add("星街すいせい");

            asobi.noWaitSerifu("武器を選択：　");


            bool choosing = true;
            int stopOverflow = weapon.Count - 1;
            int weaponNumber = 0;




            Console.WriteLine();
            Console.WriteLine(weapon[weaponNumber]);
            while (choosing)
            {
                int left = Console.CursorLeft;
                int top = Console.CursorTop - 1;
                ConsoleKeyInfo choose = Console.ReadKey();
                if (choose.Key.ToString() == "UpArrow")
                {
                    weaponNumber++;
                    if (weaponNumber > stopOverflow)
                    {
                        weaponNumber = 0;
                    }
                    else { }
                    Console.SetCursorPosition(left, top);
                    Console.WriteLine("                                  ");
                    Console.SetCursorPosition(left, top);
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
                    Console.SetCursorPosition(left, top);
                    Console.WriteLine("                                  ");
                    Console.SetCursorPosition(left, top);
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
                asobi.noWaitSerifu(i);
            }
            asobi.serifu("をもっていこう");
            //-----------------------武器選択----------------------//




            //-----------------持ち物検査---------------//

            //----武器--//
            if (weaponSlot.Contains("ペーパーナイフ"))
            {
                playerAtk = playerAtk + 2;
                knife = true;
            }
            else if (weaponSlot.Contains("徹底解説！はじめての魔法"))
            {
                playerMgk = playerMgk + 2;
                book = true;
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
            string itemHolder;
            while (bouken)
            {
                string basho1 = asobi._Basho("trigger");
                string basho2 = asobi._Basho("trigger");
                string basho3 = asobi._Basho("trigger");

            here:
                Console.WriteLine(" \n ");
                Console.WriteLine("     ↑" + basho1 + "↑     ");
                Console.WriteLine();
                Console.WriteLine("←" + basho2 + "        " + basho3 + "→");
                Console.WriteLine();
                Console.WriteLine("Menu: Enter");
                ConsoleKeyInfo houkou = Console.ReadKey();
                int nextEvent = rand.Next(0, 1000);

                if (houkou.Key.ToString() == "W" || houkou.Key.ToString() == "UpArrow")
                {
                    if (basho1 == "草")
                    {
                        if (nextEvent >= 0 && nextEvent < 560)
                        {
                            playerHP = enemy.kemujara(playerHP, playerAtk, playerMgk);
                            Console.WriteLine();
                            itemHolder = asobi.kemujaraItem("trigger");
                            itemslot.Add(itemHolder);
                            itemHolder = "";
                        }
                        else if (nextEvent >= 560 && nextEvent < 850)
                        {
                            playerHP = enemy.dekaihachi(playerHP, playerAtk, playerMgk);
                            Console.WriteLine();
                            itemHolder = asobi.dekaihachiItem("trigger");
                            itemslot.Add(itemHolder);
                            itemHolder = "";
                        }
                        else
                        {
                            asobi.serifu("そよ風がここちいい");
                        }
                    }

                    else if (basho1 == "泥")
                    {
                        if (nextEvent >= 0 && nextEvent < 350)
                        {
                            playerHP = enemy.kemujara(playerHP, playerAtk, playerMgk);
                            Console.WriteLine();
                            itemHolder = asobi.kemujaraItem("trigger");
                            itemslot.Add(itemHolder);
                            itemHolder = "";
                        }
                        else if (nextEvent >= 350 && nextEvent < 800)
                        {
                            playerHP = enemy.dekaihachi(playerHP, playerAtk, playerMgk);
                            Console.WriteLine();
                            itemHolder = asobi.dekaihachiItem("trigger");
                            itemslot.Add(itemHolder);
                            itemHolder = "";
                        }
                        else
                        {
                            asobi.serifu("泥人形でもつくろうかな…");
                        }
                    }

                    else if (basho1 == "道")
                    {
                        if (nextEvent >= 0 && nextEvent < 120)
                        {
                            playerHP = enemy.kemujara(playerHP, playerAtk, playerMgk);
                            Console.WriteLine();
                            itemHolder = asobi.kemujaraItem("trigger");
                            itemslot.Add(itemHolder);
                            itemHolder = "";
                        }
                        else if (nextEvent >= 120 && nextEvent < 170)
                        {
                            playerHP = enemy.dekaihachi(playerHP, playerAtk, playerMgk);
                            Console.WriteLine();
                            itemHolder = asobi.dekaihachiItem("trigger");
                            itemslot.Add(itemHolder);
                            itemHolder = "";
                        }
                        else if (nextEvent >= 170 && nextEvent < 200)
                        {
                            playerHP = enemy.kodomotori(playerHP, playerAtk, playerMgk);
                            Console.WriteLine();
                            itemHolder = asobi.kodomotoriItem("trigger");
                            itemslot.Add(itemHolder);
                            itemHolder = "";
                        }
                        else
                        {
                            asobi.serifu("しっかりと整備されている");
                        }
                    }

                    else if (basho1 == "水辺")
                    {
                        if (nextEvent >= 0 && nextEvent < 765)
                        {
                            playerHP = enemy.kemujara(playerHP, playerAtk, playerMgk);
                            Console.WriteLine();
                            itemHolder = asobi.kemujaraItem("trigger");
                            itemslot.Add(itemHolder);
                            itemHolder = "";
                        }
                        else if (nextEvent <= 765 && nextEvent > 950)
                        {
                            playerHP = enemy.dekaihachi(playerHP, playerAtk, playerMgk);
                            Console.WriteLine();
                            itemHolder = asobi.dekaihachiItem("trigger");
                            itemHolder = "";
                        }
                        else
                        {
                            asobi.serifu("水は透き通るようにきれいだ");
                        }
                    }
                }





                else if (houkou.Key.ToString() == "A" || houkou.Key.ToString() == "LeftArrow")
                {
                    if (basho2 == "草")
                    {
                        if (nextEvent >= 0 && nextEvent < 560)
                        {
                            playerHP = enemy.kemujara(playerHP, playerAtk, playerMgk);
                            Console.WriteLine();
                            itemHolder = asobi.kemujaraItem("trigger");
                            itemslot.Add(itemHolder);
                            itemHolder = "";
                        }
                        else if (nextEvent >= 560 && nextEvent < 850)
                        {
                            playerHP = enemy.dekaihachi(playerHP, playerAtk, playerMgk);
                            Console.WriteLine();
                            itemHolder = asobi.dekaihachiItem("trigger");
                            itemslot.Add(itemHolder);
                            itemHolder = "";
                        }
                        else
                        {
                            asobi.serifu("そよ風がここちいい");
                        }
                    }

                    else if (basho2 == "泥")
                    {
                        if (nextEvent >= 0 && nextEvent < 350)
                        {
                            playerHP = enemy.kemujara(playerHP, playerAtk, playerMgk);
                            Console.WriteLine();
                            itemHolder = asobi.kemujaraItem("trigger");
                            itemslot.Add(itemHolder);
                            itemHolder = "";
                        }
                        else if (nextEvent >= 350 && nextEvent < 800)
                        {
                            playerHP = enemy.dekaihachi(playerHP, playerAtk, playerMgk);
                            Console.WriteLine();
                            itemHolder = asobi.dekaihachiItem("trigger");
                            itemslot.Add(itemHolder);
                            itemHolder = "";
                        }
                        else
                        {
                            asobi.serifu("泥人形でもつくろうかな…");
                        }
                    }

                    else if (basho2 == "道")
                    {
                        if (nextEvent >= 0 && nextEvent < 120)
                        {
                            playerHP = enemy.kemujara(playerHP, playerAtk, playerMgk);
                            Console.WriteLine();
                            itemHolder = asobi.kemujaraItem("trigger");
                            itemslot.Add(itemHolder);
                            itemHolder = "";
                        }
                        else if (nextEvent >= 120 && nextEvent < 170)
                        {
                            playerHP = enemy.dekaihachi(playerHP, playerAtk, playerMgk);
                            Console.WriteLine();
                            itemHolder = asobi.dekaihachiItem("trigger");
                            itemslot.Add(itemHolder);
                            itemHolder = "";
                        }
                        else if (nextEvent >= 170 && nextEvent < 200)
                        {
                            playerHP = enemy.kodomotori(playerHP, playerAtk, playerMgk);
                            Console.WriteLine();
                            itemHolder = asobi.kodomotoriItem("trigger");
                            itemslot.Add(itemHolder);
                            itemHolder = "";
                        }
                        else
                        {
                            asobi.serifu("しっかりと整備されている");
                        }
                    }

                    else if (basho2 == "水辺")
                    {
                        if (nextEvent >= 0 && nextEvent < 765)
                        {
                            playerHP = enemy.kemujara(playerHP, playerAtk, playerMgk);
                            Console.WriteLine();
                            itemHolder = asobi.kemujaraItem("trigger");
                            itemslot.Add(itemHolder);
                            itemHolder = "";
                        }
                        else if (nextEvent <= 765 && nextEvent > 950)
                        {
                            playerHP = enemy.dekaihachi(playerHP, playerAtk, playerMgk);
                            Console.WriteLine();
                            itemHolder = asobi.dekaihachiItem("trigger");
                            itemHolder = "";
                        }
                        else
                        {
                            asobi.serifu("水は透き通るようにきれいだ");
                        }
                    }
                }





                else if (houkou.Key.ToString() == "S" || houkou.Key.ToString() == "DownArrow")
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    asobi.serifu("そろそろ帰ろうかな？");
                    int optionSwitcher = 0;
                    bool option = true;
                    Console.WriteLine("うん ◁\nまだ");
                    while (option)
                    {
                        int houkouLeft = Console.CursorLeft;
                        int houkouTop = Console.CursorTop - 1;
                        if (optionSwitcher == 0)
                        {
                            Console.SetCursorPosition(houkouLeft, houkouTop - 1);
                            Console.WriteLine("              \n             ");
                            Console.SetCursorPosition(houkouLeft, houkouTop - 1);
                            Console.WriteLine("うん ◁\nまだ");
                            ConsoleKeyInfo choose = Console.ReadKey();
                            if (choose.Key.ToString() == "DownArrow")
                            {
                                optionSwitcher = 1;
                            }
                            else if (choose.Key.ToString() == "UpArrow")
                            {
                                continue;
                            }
                            else if (choose.Key.ToString() == "Enter")
                            {
                                option = false;
                            }
                            else { }
                        }
                        else if (optionSwitcher == 1)
                        {
                            Console.SetCursorPosition(houkouLeft, houkouTop - 1);
                            Console.WriteLine("              \n             ");
                            Console.SetCursorPosition(houkouLeft, houkouTop - 1);
                            Console.WriteLine("うん\nまだ ◁");
                            ConsoleKeyInfo choose = Console.ReadKey();
                            if (choose.Key.ToString() == "UpArrow")
                            {
                                optionSwitcher = 0;
                            }
                            else if (choose.Key.ToString() == "DownArrow")
                            {
                                continue;
                            }
                            else if (choose.Key.ToString() == "Enter")
                            {
                                option = false;
                            }
                            else { }
                        }
                        else
                        {
                            continue;
                        }
                    }
                    if (optionSwitcher == 0)
                    {
                        //帰る
                    }
                    else if (optionSwitcher == 1)
                    {
                        goto here;
                    }
                }





                else if (houkou.Key.ToString() == "D" || houkou.Key.ToString() == "RightArrow")
                {
                    if (basho3 == "草")
                    {
                        if (nextEvent >= 0 && nextEvent < 560)
                        {
                            playerHP = enemy.kemujara(playerHP, playerAtk, playerMgk);
                            Console.WriteLine();
                            itemHolder = asobi.kemujaraItem("trigger");
                            itemslot.Add(itemHolder);
                            itemHolder = "";
                        }
                        else if (nextEvent >= 560 && nextEvent < 850)
                        {
                            playerHP = enemy.dekaihachi(playerHP, playerAtk, playerMgk);
                            Console.WriteLine();
                            itemHolder = asobi.dekaihachiItem("trigger");
                            itemslot.Add(itemHolder);
                            itemHolder = "";
                        }
                        else
                        {
                            asobi.serifu("そよ風がここちいい");
                        }
                    }

                    else if (basho3 == "泥")
                    {
                        if (nextEvent >= 0 && nextEvent < 350)
                        {
                            playerHP = enemy.kemujara(playerHP, playerAtk, playerMgk);
                            Console.WriteLine();
                            itemHolder = asobi.kemujaraItem("trigger");
                            itemslot.Add(itemHolder);
                            itemHolder = "";
                        }
                        else if (nextEvent >= 350 && nextEvent < 800)
                        {
                            playerHP = enemy.dekaihachi(playerHP, playerAtk, playerMgk);
                            Console.WriteLine();
                            itemHolder = asobi.dekaihachiItem("trigger");
                            itemslot.Add(itemHolder);
                            itemHolder = "";
                        }
                        else
                        {
                            asobi.serifu("泥人形でもつくろうかな…");
                        }
                    }

                    else if (basho3 == "道")
                    {
                        if (nextEvent >= 0 && nextEvent < 120)
                        {
                            playerHP = enemy.kemujara(playerHP, playerAtk, playerMgk);
                            Console.WriteLine();
                            itemHolder = asobi.kemujaraItem("trigger");
                            itemslot.Add(itemHolder);
                            itemHolder = "";
                        }
                        else if (nextEvent >= 120 && nextEvent < 170)
                        {
                            playerHP = enemy.dekaihachi(playerHP, playerAtk, playerMgk);
                            Console.WriteLine();
                            itemHolder = asobi.dekaihachiItem("trigger");
                            itemslot.Add(itemHolder);
                            itemHolder = "";
                        }
                        else if (nextEvent >= 170 && nextEvent < 200)
                        {
                            playerHP = enemy.kodomotori(playerHP, playerAtk, playerMgk);
                            Console.WriteLine();
                            itemHolder = asobi.kodomotoriItem("trigger");
                            itemslot.Add(itemHolder);
                            itemHolder = "";
                        }
                        else
                        {
                            asobi.serifu("しっかりと整備されている");
                        }
                    }

                    else if (basho3 == "水辺")
                    {
                        if (nextEvent >= 0 && nextEvent < 765)
                        {
                            playerHP = enemy.kemujara(playerHP, playerAtk, playerMgk);
                            Console.WriteLine();
                            itemHolder = asobi.kemujaraItem("trigger");
                            itemslot.Add(itemHolder);
                            itemHolder = "";
                        }
                        else if (nextEvent <= 765 && nextEvent > 950)
                        {
                            playerHP = enemy.dekaihachi(playerHP, playerAtk, playerMgk);
                            Console.WriteLine();
                            itemHolder = asobi.dekaihachiItem("trigger");
                            itemHolder = "";
                        }
                        else
                        {
                            asobi.serifu("水は透き通るようにきれいだ");
                        }
                    }
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
                            asobi.noWaitSerifu("武器： ");
                            foreach (string i in weaponSlot)
                            {
                                asobi.noWaitSerifu(i + " ");
                            }
                            Console.WriteLine(" 　▽");
                            Console.ReadLine();
                        }
                        else if (menuChoice.Key.ToString() == "D2")
                        {
                            asobi.noWaitSerifu("ちから：" + playerAtk);
                            Console.WriteLine();
                            asobi.noWaitSerifu("まほう：" + playerMgk);
                            Console.WriteLine();
                            asobi.noWaitSerifu("HP：" + playerHP);
                            Console.WriteLine();
                            Console.WriteLine();
                        }
                        else if (menuChoice.Key.ToString() == "D3")
                        {
                            asobi.noWaitSerifu(" アイテム： ");
                            foreach (string i in itemslot)
                            {
                                asobi.noWaitSerifu(i + " ");
                            }
                            Console.WriteLine("　 ▽");
                            Console.ReadLine();
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




        //------------------アイテムドロップ処理------------------//


        string kemujaraItem(string triggered)
        {
            Random rand = new Random();
            Asobi asobi = new Asobi();
            int itemGet = rand.Next(0, 1000);
            int rareItemGet = rand.Next(0, 100);
            string itemgot = "";
            if (rareItemGet < 5)
            {
                asobi.serifu("天然の白髪を手に入れた");
                asobi.noWaitSerifu("天然の白髪：");
                Console.WriteLine();
                asobi.noWaitSerifu("とても質のよい天然のけむくじゃらから取れた白髪");
                Console.WriteLine();
                asobi.noWaitSerifu("そもそもけむくじゃらは毛のお手入れは欠かさずやるので");
                Console.WriteLine();
                asobi.serifu("天然の白髪が取れるのはとても珍しい");
                itemgot = "天然の白髪";
            }
            else if (itemGet > 500)
            {
                asobi.serifu("さらさらな毛を手に入れた");
                asobi.noWaitSerifu("さらさらな毛：");
                Console.WriteLine();
                asobi.serifu("さらっさらな毛。さらさらすぎて掴みにくい");
                itemgot = "さらさらな毛";
            }
            return itemgot;
        }

        string dekaihachiItem(string triggered)
        {
            Random rand = new Random();
            Asobi asobi = new Asobi();
            int itemGet = rand.Next(0, 1000);
            int rareItemGet = rand.Next(0, 100);
            string itemgot = "";
            if (rareItemGet < 3)
            {
                asobi.serifu("鉄の心臓を手に入れた");
                asobi.noWaitSerifu("鉄の心臓：");
                Console.WriteLine();
                asobi.noWaitSerifu("どんな敵でも向かってくる理由がわかる強固な心臓");
                Console.WriteLine();
                asobi.serifu("でかいはちたちの高度なテクノロジーが伺える");
                itemgot = "鉄の心臓";
            }
            else if (itemGet > 650)
            {
                asobi.serifu("でかいあしを手に入れた");
                asobi.noWaitSerifu("でかいあし：");
                Console.WriteLine();
                asobi.serifu("でかいはちの足。腕くらいの長さはある");
                itemgot = "でかいあし";
            }
            return itemgot;
        }

        string kodomotoriItem(string triggered)
        {
            Random rand = new Random();
            Asobi asobi = new Asobi();
            int itemGet = rand.Next(0, 1000);
            int rareItemGet = rand.Next(0, 100);
            string itemgot = "";
            if (rareItemGet < 40)
            {
                asobi.serifu("上級回復薬を手に入れた");
                asobi.noWaitSerifu("上級回復薬：");
                Console.WriteLine();
                asobi.noWaitSerifu("不治の病を治すために使われたと言われている");
                Console.WriteLine();
                asobi.noWaitSerifu("今の時代で言うかぜ薬");
                Console.WriteLine();
                asobi.serifu("HPを10回復");
                itemgot = "上級回復薬";
            }
            else if (itemGet > 650)
            {
                asobi.serifu("回復薬を手に入れた");
                asobi.noWaitSerifu("回復薬：");
                Console.WriteLine();
                asobi.noWaitSerifu("どんな傷でもぴたりと直せると言われている");
                Console.WriteLine();
                asobi.noWaitSerifu("今の時代で言う絆創膏");
                Console.WriteLine();
                asobi.serifu("HPを5回復");
                itemgot = "回復薬";
            }
            return itemgot;
        }
        //------------------アイテムドロップ処理------------------//





        //----------------------------セリフ処理---------------------------//
        public void serifu(string word)
        {
            var nagasa = new List<char>();

            for (int i = 0; i < word.Length; i++)
            {
                nagasa.Add(word[i]);
            }

            foreach (char i in nagasa)
            {
                Console.Write(i);
                Thread.Sleep(80);
            }
            Console.WriteLine("  ▽");
            Console.Read();
            Console.Clear();
        }

        public void noWaitSerifu(string word)
        {
            
            var nagasa = new List<char>();

            for (int i = 0; i < word.Length; i++)
            {
                nagasa.Add(word[i]);
            }

            foreach (char i in nagasa)
            {
                Console.Write(i);
                Thread.Sleep(80);
            }
        }
        //-------------------------セリフ処理--------------------------//


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





        






        //-------------------ブルースライム処理--------------------//
        int blueSlime(int playerHP, int playerAtk, int playerMgk)
        {
            Asobi asobi = new Asobi();
            Random rand = new Random();
            int enemyHP = 10;
            asobi.serifu("ブルースライムが現れた");
            Thread.Sleep(500);

            while (enemyHP > 0)
            {
                bool choosing = true;
                int stopOverflow = 1;
                int optionNumber = 0;
                asobi.noWaitSerifu("どうする？");
                Console.WriteLine();
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Attack");
                Console.ResetColor();
                Console.WriteLine("/Magic");
                while (choosing)
                {
                    int left = Console.CursorLeft;
                    int top = Console.CursorTop - 1;
                    ConsoleKeyInfo choose = Console.ReadKey();
                    if (choose.Key.ToString() == "RightArrow")
                    {
                        optionNumber++;
                        if (optionNumber > stopOverflow)
                        {
                            optionNumber = stopOverflow;
                        }
                        else { }
                        if (optionNumber == 0)
                        {
                            Console.SetCursorPosition(left, top);
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("Attack");
                            Console.ResetColor();
                            Console.WriteLine("/Magic");
                        }
                        else if (optionNumber == 1)
                        {
                            Console.SetCursorPosition(left, top);
                            Console.Write("Attack/");
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("Magic");
                            Console.ResetColor();
                        }
                        else { }
                    }
                    else if (choose.Key.ToString() == "LeftArrow")
                    {
                        optionNumber--;
                        if (optionNumber < 0)
                        {
                            optionNumber = 0;
                        }
                        else { }
                        if (optionNumber == 0)
                        {
                            Console.SetCursorPosition(left, top);
                            Console.WriteLine("                      ");
                            Console.SetCursorPosition(left, top);
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("Attack");
                            Console.ResetColor();
                            Console.WriteLine("/Magic");
                        }
                        else if (optionNumber == 1)
                        {
                            Console.SetCursorPosition(left, top);
                            Console.WriteLine("                      ");
                            Console.SetCursorPosition(left, top);
                            Console.Write("Attack/");
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("Magic");
                            Console.ResetColor();
                        }
                        else { }
                    }
                    else if (choose.Key.ToString() == "Enter")
                    {
                        choosing = false;
                    }
                    else
                    {
                        continue;
                    }
                }

                Thread.Sleep(500);
                int _left = Console.CursorLeft;
                int _top = Console.CursorTop - 2;
                Console.SetCursorPosition(_left, _top);
                Console.WriteLine("                 \n              ");
                Console.SetCursorPosition(_left, Console.CursorTop - 2);
                if (optionNumber == 0)
                {
                    int damageDone = rand.Next((playerAtk - 1), (playerAtk + 4));
                    //blueSlime(damageDone, hp);
                    enemyHP = enemyHP - damageDone;
                    asobi.noWaitSerifu("ブルースライムに殴りかかった");
                    Thread.Sleep(500);
                    Console.WriteLine();
                    asobi.noWaitSerifu("ブルースライムに" + damageDone + "ダメージ...  ");
                    Thread.Sleep(500);
                    if (enemyHP > 0)
                    {
                        asobi.serifu("残り" + enemyHP + "HPだ");
                    }
                    else if (enemyHP <= 0)
                    {
                        asobi.serifu("ブルースライムを倒した");
                        break;
                    }

                    Thread.Sleep(1000);
                }

                else if (optionNumber == 1)
                {
                    int damageDone = rand.Next((playerMgk - 2), (playerMgk + 6));
                    enemyHP = enemyHP - damageDone;
                    asobi.noWaitSerifu("ブルースライムへ呪文を唱えた");
                    Thread.Sleep(500);
                    Console.WriteLine();
                    asobi.noWaitSerifu("ブルースライムに" + damageDone + "ダメージ...  ");
                    Thread.Sleep(500);
                    if (enemyHP > 0)
                    {
                        asobi.serifu("残り" + enemyHP + "HPだ");
                    }
                    else if (enemyHP <= 0)
                    {
                        asobi.serifu("ブルースライムを倒した");
                        break;
                    }
                }

                else
                {
                    continue;
                }
                int damageTook = rand.Next(1, 4);

                asobi.noWaitSerifu("ブルースライムの攻撃...  ");
                Thread.Sleep(500);
                asobi.serifu("君に" + damageTook + "ダメージ");
                playerHP = playerHP - damageTook;


                if (playerHP <= 0)
                {
                    asobi.serifu("目の前がまっさおになった");
                    Console.WriteLine();
                    Console.WriteLine("おしまい");
                    Environment.Exit(0);
                }
                else
                {
                    asobi.serifu("君のHPはあと" + playerHP + "HPだ");
                }


            }
            return playerHP;
            Thread.Sleep(2000);
        }
        //-------------------ブルースライム処理--------------------//
    }
}