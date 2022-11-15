using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace kore
{
    public class Story1
    {
        public void hanashi1()
        {
            Asobi asobi = new Asobi();
            Story1 story1 = new Story1();
            asobi.serifu("第一章：創生の本");
            story1.luka();
            Thread.Sleep(120);
            asobi.noWaitSerifu("まぁすたー");
            Thread.Sleep(20);
            asobi.serifu("ひまだよー");
            story1.luka();
            asobi.serifu("なんかやることないのー？");
            story1.master();
            Thread.Sleep(120);
            asobi.noWaitSerifu("そうだね...");
            Thread.Sleep(120);
            asobi.serifu("それなら、そこに散乱しているゴミの山を片付けてくれないか");
            story1.luka();
            Thread.Sleep(120);
            asobi.noWaitSerifu("ゴミ？！");
            Thread.Sleep(20);
            asobi.noWaitSerifu("ゴミとは失礼な！これは全部私の大切な宝物たちだよ！");
            story1.master();
            Thread.Sleep(120);
            asobi.serifu("そのお菓子の空袋もかい？");
            story1.luka();
            Thread.Sleep(120);
            asobi.noWaitSerifu("うっっ");
            Thread.Sleep(20);
        }

        private void luka()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("流歌");
            Console.ResetColor();
            Console.WriteLine("：");
        }
        private void master()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("マスター");
            Console.ResetColor();
            Console.WriteLine("：");
        }
    }
}

