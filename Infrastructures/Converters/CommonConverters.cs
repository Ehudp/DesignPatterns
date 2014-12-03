using Infrastructures.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructures.Converters
{
    public static class CommonConverters
    {
        public static DebugConverter DebugConverter = new DebugConverter();

        public static BooleanToVisibilityConverter BooleanToVisibilityConverter = new BooleanToVisibilityConverter();
    }
}
