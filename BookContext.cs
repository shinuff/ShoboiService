using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace GetShoboiElements {
    class BookContext {
        public BookContext() {

        }
        // 特定のフォルダのファイルリストからベースとなるルールに基づいたファイル名を抜き出しベース名毎に巻数を取得

        // 特定のURLから取得されるダウンロードリストを元にダウンロード側ベース名を作成
        ShoboiService sb = new ShoboiService();
        sb.GetContentPage();

        internal void GetContentPage() {

        }
    }
    internal class ShoboiService {
        public ShoboiService() {
        }
    }
}
