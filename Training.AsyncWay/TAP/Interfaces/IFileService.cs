using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Training.AsyncWay.TAP.Interfaces
{
    interface IFileService
    {
        /// <summary>
        /// returns a list of all files that meet a particular search pattern, the progress callback could provide 
        /// an estimate of the percentage of work completed as well as the current set of partial results
        /// </summary>
        /// <param name="pattern"></param>
        /// <param name="progress"></param>
        /// <returns></returns>
        Task<ReadOnlyCollection<FileInfo>> FindFilesAsync(string pattern, IProgress<Tuple<double, ReadOnlyCollection<List<FileInfo>>>> progress);
    }
}
