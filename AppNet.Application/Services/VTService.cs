using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNet.Application.Services
{
    public class VTService
    {

        public void VTJSKaydet()
        {    
            string path = @"dosyam.txt";
            File.Create(path);
        }

        public void VTJSOku()
        {
            string path = @"dosyam.txt";
            File.Create(path);
        }




    }
}
