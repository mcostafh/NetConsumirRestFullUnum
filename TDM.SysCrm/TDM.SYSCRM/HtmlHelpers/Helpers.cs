using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Linq.Expressions;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using Newtonsoft.Json;
using System.Web.Script.Serialization;

namespace TDM.SysCRM.HtmlHelpers
{

    public class PropertiesButtons
    {
        public string Label { get; set; }
        public string Action { get; set; }
        public Boolean Submit { get; set; }
        public string Id { get; set; }
    }

    public class PropertiesQuantityColumns
    {
        public int Xs { get; set; }
        public int Md { get; set; }
        public int Lg { get; set; }

        public PropertiesQuantityColumns()
        {
            Xs = 12;
            Md = 8;
            Lg = 4;
        }

    }

    public static class Helpers
    {

        public static MvcHtmlString Qualquer<TModel, TProperty>(this HtmlHelper<TModel> html,
            Expression<Func<TModel, TProperty>> expression)
        {
            var template = "<span>";
            template += "Nome: ";
            template += html.DisplayFor(expression).ToHtmlString();
            template += "</span>";

            return new MvcHtmlString(template);
        }

        public static MvcHtmlString MyGridcollapse(this HtmlHelper value, string Id)
        {
            return new MvcHtmlString("<div class='collapse' id='" + Id + "'>");
        }
        public static MvcHtmlString MyEndGridcollapse(this HtmlHelper value)
        {
            return new MvcHtmlString("</div>");
        }

        public static string TemplateCard(string Id, PropertiesQuantityColumns objQuantCols)
        {
            var template = "<div class='row form-inline' id='" + Id + "'>";

            template += "<div class='container'>";
            //template += "    <div class='row'>";
            template += "        <div class='row col-xs-"+objQuantCols.Xs.ToString()+" col-md-"+ objQuantCols.Md.ToString() + "'>";


            template += "       <div class='card text-center'>";
            template += "           <div class='card-header'>";

            return template;
        }


        public static MvcHtmlString MyPanel(this HtmlHelper value, string Id, string titulo, PropertiesQuantityColumns objQuantCols )
        {
            var template = TemplateCard(Id, objQuantCols);

            template += titulo + "</div>";


            template += "                <div class='card-body'>";

            return new MvcHtmlString(template);
        }
        public static MvcHtmlString MyPanel(this HtmlHelper value, string Id, string titulo)
        {
            var objQuantCols = new PropertiesQuantityColumns();
            var template = TemplateCard(Id, objQuantCols);

            template += titulo + "</div>";


            template += "                <div class='card-body'>";

            return new MvcHtmlString(template);
        }


        public static MvcHtmlString MyEndPanel(this HtmlHelper value)
        {
            var template = "";

            template += "            </div>";
            template += "        </div>";
            template += "   </div>";
            //template += "</div>";
            template += "</div>";


            return new MvcHtmlString(template);

        }


        public static MvcHtmlString MyEndPanel(this HtmlHelper value, List<PropertiesButtons> botoes)
        {
            var template = "</div>";
            template += "<div class='card-footer'>";
            template += " <div class='btn-group' role='group' aria-label='Third group'>";
            template += "   <ul class='nav nav-pills card-footer-pills ' >";
            foreach (PropertiesButtons botao in botoes)
            {
                template += "<li class='nav-item' >";
                if (botao.Submit)
                {
                    template += "<input type = 'submit' value = "+botao.Label+" id = '"+botao.Id + "' class='btn btn-primary btn-md pad-right' />";
                }else{
                    template += "<a href = '" + botao.Action + "' class='nav-item btn btn-primary btn-xs pad-right' role='button' aria-pressed='true'>" + botao.Label + "</a> ";
                }
                template += "</li>";
            }
            template += "</ul>";
            template += "</div>";

            template += "</div>";

            template += "            </div>";
            template += "        </div>";
            template += "   </div>";
            template += "</div>";
            template += "</div>";


            return new MvcHtmlString(template);

        }


        public static MvcHtmlString MyGridInTable(this HtmlHelper value, int colunas)
        {

            var template = "       <div class='row'>";
            template += "           <div class='col-xs-" + colunas + "'>";
            template += "               <div class='table-responsive'>";
            template += "                 <table class='table table-bordered table-striped table-hover table-condensed'>";

            return new MvcHtmlString(template);
        }

        public static MvcHtmlString MyGridInTableHeader(this HtmlHelper value, List<string> colunas)
        {
            var template = "   <tread>";
            template += "<tr class='info'>";


            // Iterate through the list.  
            foreach (var col in colunas)
            {
                template += "<th>" + col;
            }
            template += "</tr></tread>";
            return new MvcHtmlString(template);
        }


        public static MvcHtmlString MyEndGridInTable(this HtmlHelper value)
        {
            var template = "       </div>";
            template += "           </div>";
            template += "               </div>";
            template += "                 </table>";

            return new MvcHtmlString(template);
        }

        public static MvcHtmlString MyButtonEdit<TModel>(this HtmlHelper<TModel> html, long Id)
        {
            return html.ActionLink(" ", "Edit", new { id = Id }, new { @class = "btn btn-primary btn-xs glyphicon glyphicon-edit" });
        }

        public static MvcHtmlString MyButtonDetails<TModel>(this HtmlHelper<TModel> html, long Id)
        {

            return html.ActionLink(" ", "Details", new { id = Id }, new { @class = "btn btn-success btn-xs glyphicon glyphicon-info-sign" });
        }
        public static MvcHtmlString MyButtonDelete<TModel>(this HtmlHelper<TModel> html, long Id)
        {
            // return html.ActionLink(" ", "Delete", new { id = Id }, new { @class = "btn btn-danger btn-xs glyphicon glyphicon-minus-sign" });
            return html.ActionLink(" ", "Delete", new { id = Id }, new { @class = "btn btn-danger btn-xs glyphicon glyphicon-minus-sign" });
            // <svg-icon><src href="sprite.svg#si-glyph-button-remove" /></svg-icon>


        }

        public static MvcHtmlString MyButtonLink<TModel>(this HtmlHelper<TModel> html, string Label, string Url , string Id )
        {
            return new MvcHtmlString(" <a href = '" + Url + "' class='btn btn-default btn-md active' role='button' aria-pressed='true'>" + Label + "</a> ");
        }

        public static MvcHtmlString MyButtonWell<TModel>(this HtmlHelper<TModel> html, List<PropertiesButtons> botoes )
        {
            
            var template = "";
            template += "<div class='well well-sm'> ";  // 

            foreach (PropertiesButtons botao in botoes)
            {
                template += "    <a href = '" + botao.Action + "' class='btn btn-default btn-md active' role='button' aria-pressed='true'>" + botao.Label + "</a> ";
            }

            template += "</div>";
            return new MvcHtmlString(template);
        }

 

        public static MvcHtmlString MyButtonSubmit<TModel>(this HtmlHelper<TModel> html, string NomeButton)
        {
            var template = "";

            template += "<div class='well well-sm'>";
            template += "       <input type = 'submit' value='" + NomeButton + "' class='btn btn-primary btn-md' />";
            template += "</div>";
            return new MvcHtmlString(template);
        }

    }
}