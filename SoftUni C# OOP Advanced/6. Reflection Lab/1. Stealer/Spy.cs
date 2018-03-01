namespace _1.Stealer
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Text;

    public class Spy
    {
        public string StealFieldInfo(string className, params string[] fieldNames)
        {
            Type classType = Type.GetType($"_1.Stealer.{className}");
            var fieldsInfo = classType.GetFields(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
            var hacker = Activator.CreateInstance(classType);
            var sb = new StringBuilder();
            sb.AppendLine($"Class under investigation: { className}");
            foreach (var field in fieldsInfo.Where(f => fieldNames.Contains(f.Name)))
            {
                sb.AppendLine($"{field.Name.ToString()} = {field.GetValue(hacker)}");
            }
            return sb.ToString().TrimEnd();
        }

        public string AnalyzeAccessModifiers(string className)
        {
            var sb = new StringBuilder();

            Type classType = Type.GetType($"_1.Stealer.{className}");
            var fieldsInfo = classType.GetFields(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
            var publicMethodsInfo = classType.GetMethods(BindingFlags.Instance|BindingFlags.NonPublic);
            var privateMethodsInfo = classType.GetMethods(BindingFlags.Instance|BindingFlags.Public);

            foreach (var field in fieldsInfo.Where(f=>f.IsPublic))
            {
                sb.AppendLine($"{field.Name} must be private!");
            }

            foreach (var privateGetter in publicMethodsInfo.Where(m=>m.Name.Contains("get")))
            {
                sb.AppendLine($"{privateGetter.Name} must be public!");
            }

            foreach (var publicSetter in privateMethodsInfo.Where(m=>m.Name.Contains("set")))
            {
                sb.AppendLine($"{publicSetter.Name} must be private!");
            }

            return sb.ToString().TrimEnd();
        }

        public string RevealPrivateMethods(string className)
        {
            var sb = new StringBuilder();
            var classType = Type.GetType($"_1.Stealer.{className}");
            var privateMethods = classType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);

            sb.AppendLine($"All Private Methods of Class: {classType.Name}");
            sb.AppendLine($"All Private Methods of Class: {classType.BaseType.Name}");

            foreach (var item in privateMethods)
            {
                sb.AppendLine(item.Name);
            }

            return sb.ToString().TrimEnd();
        }

        public string CollectGettersAndSetter(string className)
        {
            var sb = new StringBuilder();

            var classType = Type.GetType($"_1.Stealer.{className}");
            var methods = classType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic|BindingFlags.Public);
            foreach (var getter in methods.Where(m=>m.Name.Contains("get")))
            {
                sb.AppendLine($"{getter.Name} will return {getter.ReturnType}");
            }
            foreach (var setter in methods.Where(m=>m.Name.Contains("set")))
            {
                sb.AppendLine($"{setter.Name} will return {setter.ReturnType}");
            }

            return sb.ToString().TrimEnd();
        }
    }
}