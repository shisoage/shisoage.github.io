using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace kore
{
    public class Enemy
    {
        Asobi asobi = new Asobi();

        //--------------------コドモトリ処理---------------------//

        public int kodomotori(int playerHP, int playerAtk, int playerMgk)
        {
            Asobi asobi = new Asobi();
            Console.WriteLine();
            Console.WriteLine();
            Thread.Sleep(1000);
            Random rand = new Random();
            int enemyHP = 15;
            asobi.serifu("また新たな敵だ");
            asobi.serifu("コドモトリが現れた");

            while (enemyHP > 0)
            {
                int serifu = rand.Next(1, 101);
                if (serifu <= 47)
                {
                    asobi.noWaitSerifu("コドモトリはキョロキョロしている");
                }
                else if (serifu >= 48 && serifu <= 94)
                {
                    asobi.noWaitSerifu("コドモトリは落ち着きがない");
                }
                else
                {
                    asobi.noWaitSerifu("最近もコドモトリの誘拐事件があったような");
                }
                Console.WriteLine();
                bool choosing = true;
                int stopOverflow = 2;
                int optionNumber = 0;
                asobi.noWaitSerifu("どうする？");
                Console.WriteLine();
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Attack");
                Console.ResetColor();
                Console.WriteLine("/Magic/Info");
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
                            Console.WriteLine("/Magic/Info");
                        }
                        else if (optionNumber == 1)
                        {
                            Console.SetCursorPosition(left, top);
                            Console.Write("Attack/");
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("Magic");
                            Console.ResetColor();
                            Console.WriteLine("/Info");
                        }
                        else if (optionNumber == 2)
                        {
                            Console.SetCursorPosition(left, top);
                            Console.Write("Attack/Magic/");
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("Info");
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
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("Attack");
                            Console.ResetColor();
                            Console.WriteLine("/Magic/Info");
                        }
                        else if (optionNumber == 1)
                        {
                            Console.SetCursorPosition(left, top);
                            Console.Write("Attack/");
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("Magic");
                            Console.ResetColor();
                            Console.WriteLine("/Info");
                        }
                        else if (optionNumber == 2)
                        {
                            Console.SetCursorPosition(left, top);
                            Console.Write("Attack/Magic/");
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("Info");
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


                int _left = Console.CursorLeft;
                int _top = Console.CursorTop - 2;
                Console.SetCursorPosition(_left, _top);
                Console.WriteLine("                         \n                         ");
                Console.WriteLine();

                if (optionNumber == 0)
                {
                    int damageDone = rand.Next((playerAtk - 1), (playerAtk + 5));
                    if (damageDone <= 0)
                    {
                        damageDone = 1;
                    }
                    else { }
                    enemyHP = enemyHP - damageDone;
                    //---------武器チェック--------//
                    if (Asobi.knife)
                    {
                        asobi.serifu("急所めがけて切り込んだ");
                    }
                    else
                    {
                        asobi.serifu("思い切り殴りかかった");
                    }
                    //---------武器チェック--------//
                    asobi.noWaitSerifu("コドモトリに" + damageDone + "ダメージ...  ");
                    Thread.Sleep(500);
                    if (enemyHP > 0)
                    {
                        asobi.serifu("残り" + enemyHP + "HPだ");
                    }
                    else if (enemyHP <= 0)
                    {
                        asobi.serifu("コドモトリを倒した");
                        Thread.Sleep(1000);
                        break;
                    }

                    Thread.Sleep(1000);
                }

                else if (optionNumber == 1)
                {
                    int damageDone = rand.Next((playerMgk - 1), (playerMgk + 5));
                    if (damageDone <= 0)
                    {
                        damageDone = 1;
                    }
                    else { }
                    enemyHP = enemyHP - damageDone;
                    //---------武器チェック--------//
                    if (Asobi.book)
                    {
                        asobi.serifu("本の角で殴りかかった");
                    }
                    else
                    {
                        asobi.serifu("罵声をあびせた");
                    }
                    //---------武器チェック--------//
                    asobi.noWaitSerifu("コドモトリに" + damageDone + "ダメージ...  ");
                    Thread.Sleep(500);
                    if (enemyHP > 0)
                    {
                        asobi.serifu("残り" + enemyHP + "HPだ");
                    }
                    else if (enemyHP <= 0)
                    {
                        asobi.serifu("コドモトリを倒した");
                        break;
                    }
                }

                else if (optionNumber == 2)
                {
                    asobi.noWaitSerifu("コドモトリ：");
                    Console.WriteLine();
                    asobi.noWaitSerifu("子供をさらっては自分の巣から繋がっている異次元へと誘う猿型の魔物");
                    Console.WriteLine();
                    asobi.noWaitSerifu("助け出した子供たちはみんなボロボロの場合が多い。");
                    Console.WriteLine();
                    asobi.noWaitSerifu("人を襲うことはあまりないが、食べ物などを盗んでいくため");
                    Console.WriteLine();
                    asobi.noWaitSerifu("特別駆除対象生物に設定されている");
                    Console.WriteLine();
                    asobi.noWaitSerifu("HP: " + enemyHP + "/15");
                    Console.WriteLine();
                    asobi.serifu("攻撃力：1");
                    continue;
                }

                else
                {
                    Console.WriteLine();
                    continue;
                }
                int damageTook = rand.Next(1, 3);

                asobi.noWaitSerifu("コドモトリの攻撃...  ");
                Thread.Sleep(500);
                asobi.serifu("君に" + damageTook + "ダメージ");
                playerHP = playerHP - damageTook;


                if (playerHP <= 0)
                {
                    asobi.serifu("目の前に星が飛んでいる");
                    Console.WriteLine();
                    asobi.noWaitSerifu("おしまい");
                    Console.ReadLine();
                    Environment.Exit(0);
                }
                else
                {
                    asobi.serifu("君のHPはあと" + playerHP + "HPだ");
                }


            }
            Thread.Sleep(2000);
            return playerHP;

        }

        //--------------------コドモトリ処理---------------------//













        //--------------------でかいはち処理---------------------//

        public int dekaihachi(int playerHP, int playerAtk, int playerMgk)
        {
            Asobi asobi = new Asobi();
            Console.WriteLine();
            Console.WriteLine();
            Thread.Sleep(1000);
            Random rand = new Random();
            int enemyHP = 15;
            asobi.serifu("また新たな敵だ");
            asobi.serifu("でかいはちが現れた");

            while (enemyHP > 0)
            {
                int serifu = rand.Next(1, 101);
                if (serifu <= 47)
                {
                    asobi.noWaitSerifu("でかいはちはぶるんぶるんと羽を鳴らしている");
                }
                else if (serifu >= 48 && serifu <= 94)
                {
                    asobi.noWaitSerifu("でかいはちの鋭い針が光る");
                }
                else
                {
                    asobi.noWaitSerifu("でかいはちは無機質な目でこちらを見ている");
                }
                Console.WriteLine();
                bool choosing = true;
                int stopOverflow = 2;
                int optionNumber = 0;
                asobi.noWaitSerifu("どうする？");
                Console.WriteLine();
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Attack");
                Console.ResetColor();
                Console.WriteLine("/Magic/Info");
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
                            Console.WriteLine("/Magic/Info");
                        }
                        else if (optionNumber == 1)
                        {
                            Console.SetCursorPosition(left, top);
                            Console.Write("Attack/");
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("Magic");
                            Console.ResetColor();
                            Console.WriteLine("/Info");
                        }
                        else if (optionNumber == 2)
                        {
                            Console.SetCursorPosition(left, top);
                            Console.Write("Attack/Magic/");
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("Info");
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
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("Attack");
                            Console.ResetColor();
                            Console.WriteLine("/Magic/Info");
                        }
                        else if (optionNumber == 1)
                        {
                            Console.SetCursorPosition(left, top);
                            Console.Write("Attack/");
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("Magic");
                            Console.ResetColor();
                            Console.WriteLine("/Info");
                        }
                        else if (optionNumber == 2)
                        {
                            Console.SetCursorPosition(left, top);
                            Console.Write("Attack/Magic/");
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("Info");
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


                int _left = Console.CursorLeft;
                int _top = Console.CursorTop - 2;
                Console.SetCursorPosition(_left, _top);
                Console.WriteLine("                         \n                         ");
                Console.WriteLine();

                if (optionNumber == 0)
                {
                    int damageDone = rand.Next((playerAtk - 1), (playerAtk + 4));
                    if (damageDone <= 0)
                    {
                        damageDone = 1;
                    }
                    else { }
                    enemyHP = enemyHP - damageDone;

                    //---------武器チェック--------//
                    if (Asobi.knife)
                    {
                        asobi.serifu("意を決して切りかかった");
                    }
                    else
                    {
                        asobi.serifu("勇気を出して殴りかかった");
                    }
                    //---------武器チェック--------//

                    asobi.noWaitSerifu("でかいはちに" + damageDone + "ダメージ...  ");
                    Thread.Sleep(500);
                    if (enemyHP > 0)
                    {
                        asobi.serifu("残り" + enemyHP + "HPだ");
                    }
                    else if (enemyHP <= 0)
                    {
                        asobi.serifu("でかいはちを倒した");
                        break;
                    }

                    Thread.Sleep(1000);
                }

                else if (optionNumber == 1)
                {
                    int damageDone = rand.Next((playerMgk - 2), (playerMgk + 3));
                    if (damageDone <= 0)
                    {
                        damageDone = 1;
                    }
                    else { }
                    enemyHP = enemyHP - damageDone;

                    //---------武器チェック--------//
                    if (Asobi.book)
                    {
                        asobi.serifu("火炎魔法のページを読んだ");
                    }
                    else
                    {
                        asobi.serifu("漫画で学んだ呪文を唱えた");
                    }
                    //---------武器チェック-------//
                    asobi.noWaitSerifu("でかいはちに" + damageDone + "ダメージ...  ");
                    Thread.Sleep(500);
                    if (enemyHP > 0)
                    {
                        asobi.serifu("残り" + enemyHP + "HPだ");
                    }
                    else if (enemyHP <= 0)
                    {
                        asobi.serifu("でかいはちを倒した");
                        break;
                    }
                }

                else if (optionNumber == 2)
                {
                    asobi.noWaitSerifu("でかいはち：");
                    Console.WriteLine();
                    asobi.noWaitSerifu("けっこうでかいはち。よくよく見ると所々が機械でできている。");
                    Console.WriteLine();
                    asobi.noWaitSerifu("攻撃しない限り襲ってくることは少ないが巣が近くにあると話は別。");
                    Console.WriteLine();
                    asobi.noWaitSerifu("その鋭い針で刺してくる。当たりどころが悪いと死に至ることも");
                    Console.WriteLine();
                    asobi.noWaitSerifu("HP: " + enemyHP + "/15");
                    Console.WriteLine();
                    asobi.serifu("攻撃力：4");
                    continue;
                }

                else
                {
                    Console.WriteLine();
                    continue;
                }
                int damageTook = rand.Next(2, 7);

                asobi.noWaitSerifu("でかいはちの攻撃...  ");
                Thread.Sleep(500);
                asobi.serifu("君に" + damageTook + "ダメージ");
                playerHP = playerHP - damageTook;


                if (playerHP <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    asobi.serifu("目の前がまっかになった");
                    Console.ResetColor();
                    Console.WriteLine();
                    asobi.noWaitSerifu("おしまい");
                    Console.Read();
                    Environment.Exit(0);
                }
                else
                {
                    asobi.serifu("君のHPはあと" + playerHP + "HPだ");
                }



                Thread.Sleep(2000);
            }
            return playerHP;
        }
        //--------------------でかいはち処理---------------------//











        //--------------------けむくじゃら処理---------------------//

        public int kemujara(int playerHP, int playerAtk, int playerMgk)
        {
            Asobi asobi = new Asobi();
            Console.WriteLine();
            Console.WriteLine();
            Thread.Sleep(1000);
            Random rand = new Random();
            int enemyHP = 30;
            asobi.serifu("また新たな敵だ");
            asobi.serifu("けむくじゃらが現れた");
            Thread.Sleep(500);

            while (enemyHP > 0)
            {
                int serifu = rand.Next(0, 100);
                if (serifu <= 47)
                {
                    asobi.noWaitSerifu("けむくじゃらは毛を靡かせている");
                }
                else if (serifu > 48 && serifu <= 94)
                {
                    asobi.noWaitSerifu("けむくじゃらは楽しそうだ");
                }
                else
                {
                    asobi.noWaitSerifu("けむくじゃらはまっすぐ君の頭を見ている");
                }
                Console.WriteLine();
                bool choosing = true;
                int stopOverflow = 2;
                int optionNumber = 0;
                asobi.noWaitSerifu("どうする？");
                Console.WriteLine();
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Attack");
                Console.ResetColor();
                Console.WriteLine("/Magic/Info");
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
                            Console.WriteLine("/Magic/Info");
                        }
                        else if (optionNumber == 1)
                        {
                            Console.SetCursorPosition(left, top);
                            Console.Write("Attack/");
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("Magic");
                            Console.ResetColor();
                            Console.WriteLine("/Info");
                        }
                        else if (optionNumber == 2)
                        {
                            Console.SetCursorPosition(left, top);
                            Console.Write("Attack/Magic/");
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("Info");
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
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("Attack");
                            Console.ResetColor();
                            Console.WriteLine("/Magic/Info");
                        }
                        else if (optionNumber == 1)
                        {
                            Console.SetCursorPosition(left, top);
                            Console.Write("Attack/");
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("Magic");
                            Console.ResetColor();
                            Console.WriteLine("/Info");
                        }
                        else if (optionNumber == 2)
                        {
                            Console.SetCursorPosition(left, top);
                            Console.Write("Attack/Magic/");
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("Info");
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


                int _left = Console.CursorLeft;
                int _top = Console.CursorTop - 2;
                Console.SetCursorPosition(_left, _top);
                Console.WriteLine("                         \n                         ");
                Console.WriteLine();

                if (optionNumber == 0)
                {
                    int damageDone = rand.Next((playerAtk - 1), (playerAtk + 3));
                    if (damageDone <= 0)
                    {
                        damageDone = 1;
                    }
                    else { }
                    //blueSlime(damageDone, hp);
                    enemyHP = enemyHP - damageDone;
                    //---------武器チェック--------//
                    if (Asobi.knife)
                    {
                        asobi.serifu("切り心地が良さそうだ");
                        playerAtk++;
                    }
                    else
                    {
                        asobi.serifu("ふさふさしてそうだ");
                        playerAtk--;
                    }
                    //---------武器チェック--------//
                    asobi.noWaitSerifu("けむくじゃらに" + damageDone + "ダメージ...  ");
                    Thread.Sleep(500);
                    if (enemyHP > 0)
                    {
                        asobi.serifu("残り" + enemyHP + "HPだ");
                    }
                    else if (enemyHP <= 0)
                    {
                        asobi.serifu("けむくじゃらを倒した");
                        break;
                    }

                    Thread.Sleep(1000);
                }

                else if (optionNumber == 1)
                {
                    int damageDone = rand.Next((playerMgk - 1), (playerMgk + 6));
                    if (damageDone <= 0)
                    {
                        damageDone = 1;
                    }
                    else { }
                    enemyHP = enemyHP - damageDone;
                    //---------武器チェック--------//
                    if (Asobi.book)
                    {
                        asobi.serifu("炎魔法...はかわいそうだからやめておこう");
                        playerAtk++;
                    }
                    else
                    {
                        asobi.serifu("脱毛の呪文なんてしらないよ...");
                        playerAtk--;
                    }
                    //---------武器チェック--------//
                    asobi.noWaitSerifu("けむくじゃらに" + damageDone + "ダメージ...  ");
                    Thread.Sleep(500);
                    if (enemyHP > 0)
                    {
                        asobi.serifu("残り" + enemyHP + "HPだ");
                    }
                    else if (enemyHP <= 0)
                    {
                        asobi.serifu("けむくじゃらを倒した");
                        break;
                    }
                }

                else if (optionNumber == 2)
                {
                    asobi.noWaitSerifu("けむくじゃら：");
                    Console.WriteLine();
                    asobi.noWaitSerifu("さまざまな毛の色や種類の個体がいる。");
                    Console.WriteLine();
                    asobi.noWaitSerifu("たまに仲間同士で喧嘩をするがその時は決まって同じ見た目の" +
                    "もの同士。");
                    Console.WriteLine();
                    asobi.noWaitSerifu("基本的には人間が好きで寄ってくるが、火を見ると一目散に逃げていく");
                    Console.WriteLine();
                    asobi.noWaitSerifu("HP: " + enemyHP + "/30");
                    Console.WriteLine();
                    asobi.serifu("攻撃力：2");
                    continue;
                }

                else
                {
                    Console.WriteLine();
                    continue;
                }
                int damageTook = rand.Next(1, 4);

                asobi.noWaitSerifu("けむくじゃらの攻撃...  ");
                Thread.Sleep(500);
                asobi.serifu("君に" + damageTook + "ダメージ");
                playerHP = playerHP - damageTook;


                if (playerHP <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    asobi.serifu("目の前がけだらけになった");
                    Console.ResetColor();
                    Console.WriteLine();
                    asobi.noWaitSerifu("おしまい");
                    Console.Read();
                    Environment.Exit(0);
                }
                else
                {
                    asobi.serifu("君のHPはあと" + playerHP + "HPだ");
                    Console.WriteLine();
                }


            }
            Thread.Sleep(2000);
            return playerHP;

        }

        //--------------------けむくじゃら処理---------------------//
    }

}
