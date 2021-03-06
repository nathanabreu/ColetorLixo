﻿using ColetorLixo.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace ColetorLixo.Utils
{
    public static class ConstructTable
    {
        public static void BuildTable(MatrixViewModel matrixVM)
        {
            matrixVM.Html = new StringBuilder();
            matrixVM.Html.Append("<table>");
            ConstructTable.BuildHeader(matrixVM);
            matrixVM.Html.Append("<tbody>");
            ConstructTable.BuildBody(matrixVM);
            matrixVM.Html.Append("</tbody></table>");
        }

        private static void BuildHeader(MatrixViewModel matrixVM)
        {
            matrixVM.Html.Append("<thead><th class='black'></th>");
            for (int i = 0; i < matrixVM.Matrix.GetLength(0); i++)
            {
                matrixVM.Html.Append("<th> " + (i + 1) + "</th>");
            }
            matrixVM.Html.Append("</thead>");
        }

        private static void BuildBody(MatrixViewModel matrixVM)
        {
            for (int i = 0; i < matrixVM.Matrix.GetLength(0); i++)
            {
                matrixVM.Html.Append("<tr><td> " + (i + 1) + "</td>");

                for (int j = 0; j < matrixVM.Matrix.GetLength(1); j++)
                    matrixVM.Html.Append("<td></td>");

                matrixVM.Html.Append("</tr>");
            }
        }
    }
}
