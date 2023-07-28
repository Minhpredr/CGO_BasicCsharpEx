using CGO_buoi12;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGO_buoi12
{
    public enum FIELD { FLD_EMPTY = ' ', FLD_X = 'X', FLD_O = 'O' }
    public class Cell
    {
        //Giá trị hiển thị tại ô
        FIELD fieldState = FIELD.FLD_EMPTY;
        //Khởi tạo ô giá trị rỗng
        public Cell()
        {
            fieldState = FIELD.FLD_EMPTY;
        }
        //Lấy giá trị tại ô
        public FIELD getFieldState()
        {
            return fieldState;
        }
        //Kiểm tra ô rỗng
        public bool isEmpty()
        {
            if (fieldState != FIELD.FLD_EMPTY) //X hoac O
                return false;
            return true;
        }
        //Gán giá trị tại ô theo dấu
        public void markField(Player player)
        {
            if (isEmpty())
            {
                if (player.getSign() == 'X')
                    fieldState = FIELD.FLD_X;
                else
                    fieldState = FIELD.FLD_O;
            }
        }
    }
}