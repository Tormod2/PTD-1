using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FuncionalPTD.FunctionalClasses;
using FuncionalPTD.FunctionalInterfaces;
using DomainPTD.DomainClasses;
using Excel = Microsoft.Office.Interop.Excel;
using DomainPTD.DomainInterfaces;

namespace FuncionalPTD.FunctionalClasses
{
    public delegate List<Work> MakeFunction(IWorkFile workFileList);

    public class CASFileMaker : IFileMaker
    {
        public CASFileMaker()
        {
            TypeFileList.Add("xlsx", ExcelMakeWorkList);
        }

        public Dictionary<string, MakeFunction> TypeFileList { get; set; }
            = new Dictionary<string, MakeFunction>();

        public IWorkFile MakeFile(List<IWorkFile> ExcelMakeWorkList)
        {
            List<List<Work>> allWorks = new List<List<Work>>();
            foreach (var temp in workFileList)
            {
                MakeFunction function = TypeFileList[temp.Extension];
                a
            }
        }

        public List<Work> ExcelMakeWorkList(IWorkFile workFileList)
        {
            throw new NotImplementedException();
        }

    }
}
