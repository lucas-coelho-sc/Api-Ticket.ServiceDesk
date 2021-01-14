using System;
using System.Collections.Generic;
using System.Text;

namespace ClasseDeTabela
{
    public class TblAtendimentoDeltaLog
    {
        public int Id { get; set; }
        public string Motorista { get; set; }
        public string  Monitor { get; set; }
        public string Shift { get; set; }
        public string Placa { get; set; }
        public  ulong Imei  { get; set; }
        public string Analista { get; set; }
        public  string  Origem { get; set; }
        public string Problema { get; set; }
        public string Acao { get; set; }
        public string Data { get; set; }
    }
}
