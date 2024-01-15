using System.Reflection;

namespace CleanArchitecture.Applicaton;
public static class AssemblyReference
{
    public static readonly Assembly assembly=typeof(Assembly).Assembly;
}
