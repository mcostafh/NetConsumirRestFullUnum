using System;
using System.Reflection;

namespace TDM.Repositorios.Comum.Rest.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}