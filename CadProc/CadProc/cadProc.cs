using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.EditorInput;
using Autodesk.AutoCAD.Runtime;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Geometry;


using DNA;          // Dotnet6.0


namespace CadProc
{
    public class cadProc
    {
        [CommandMethod("HelloWorld")]
        public void HelloWorld()
        {
            Line line = new Line(new Point3d(0, 0, 0), new Point3d(100, 100, 0));       
            Tools.AddToModelSpace(line);
        }


    }
}
