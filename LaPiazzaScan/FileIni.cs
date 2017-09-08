/*
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
*/

using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;

namespace LaPiazzaScan
{
    class FileIni
    {
        string _path;
        string _exe = Assembly.GetExecutingAssembly().GetName().Name;

        [DllImport("kernel32", CharSet = CharSet.Unicode)]
        static extern long WritePrivateProfileString(string Section, string Key, string Value, string FilePath);

        [DllImport("kernel32", CharSet = CharSet.Unicode)]
        static extern int GetPrivateProfileString(string Section, string Key, string Default, StringBuilder RetVal, int Size, string FilePath);

        public void IniFile(string IniPath = null)
        {
            _path = new FileInfo(IniPath ?? _exe + ".ini").FullName.ToString();
        }

        public string Read(string Key, string Section = null)
        {
            var RetVal = new StringBuilder(1000);
            GetPrivateProfileString(Section ?? _exe, Key, "", RetVal, 1000, _path);
            return RetVal.ToString();
        }

        public void Write(string Key, string Value, string Section = null)
        {
            WritePrivateProfileString(Section ?? _exe, Key, Value, _path);
        }

        public void DeleteKey(string Key, string Section = null)
        {
            Write(Key, null, Section ?? _exe);
        }

        public void DeleteSection(string Section = null)
        {
            Write(null, null, Section ?? _exe);
        }

        public bool KeyExists(string Key, string Section = null)
        {
            return Read(Key, Section).Length > 0;
        }
    }

    /*
    class FileIni2
    {
        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true, ExactSpelling = true)]
		private static extern int GetPrivateProfileString(string lpApplicationName, string lpKeyName, string lpDefault, string lpReturnedString, int nSize, string lpFileName);

		[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true, ExactSpelling = true)]
		private static extern int WritePrivateProfileString(string lpApplicationName, string lpKeyName, string lpString, string lpFileName);

		public static string Read(string Filename, string Section, string Key)
		{
			string Result = null;
			string RetVal = new string(" ", 255);
			int LenResult = 0;
			long ErrCode = 0;
			string ErrString = null;
			LenResult = GetPrivateProfileString(Section, Key, "", RetVal, RetVal.length, Filename);


			if (LenResult == 0) {
				if (!(File.Exists(Filename))) {
					ErrString = "Impossibile trovare il file " + Filename;
				} else {
					ErrString = "Impossibile eseguire l'operazione: la sezione o la chiave sono errate oppure l'accesso al file non è consentito";
				}

				throw new IniException(ErrString);
			}

			Result = RetVal.subString(0, LenResult);
			return Result;
		}

		public static void Write(string Filename, string Section, string Key, string Value)
		{
			int LenResult = 0;
			string ErrString = null;
			LenResult = WritePrivateProfileString(Section, Key, Value, Filename);
			if (LenResult == 0) {
				if (!(File.Exists(Filename))) {
					ErrString = "Impossibile trovare il file " + Filename;
				} else {
					ErrString = "Impossibile eseguire l'operazione: accesso al file non consentito";
				}

				throw new IniException(ErrString);
			}

		}
    }

    public class IniException: Exception
	{
		public IniException()
		{
		}

		public IniException(string message) : base(message)
		{
		}

		public IniException(string message, Exception inner) : base(message, inner)
		{
		}
	}
    */
}
