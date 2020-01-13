using System;
using System.Web.Mvc;

namespace Caminhoneiro.Util
{
    public static class ExtendMethods
    {
        public static bool HasAttribute(this ActionExecutingContext context, Type attribute)
        {
            var actionDesc = context.ActionDescriptor;
            var controllerDesc = actionDesc.ControllerDescriptor;

            bool allowAnon =
                actionDesc.IsDefined(attribute, true) ||
                controllerDesc.IsDefined(attribute, true);

            return allowAnon;
        }
    }
}
