namespace Main_system.Use_cases.Dynamic_mapping
{
    public class Mapper
    {
        public static void Mappe(object source, object destination)
        {
            foreach (var item in source.GetType().GetProperties())
            {
                var targetProperty = destination.GetType().GetProperty(item.Name);
                if (targetProperty != null)
                {
                    var value = item.GetValue(source);
                    targetProperty.SetValue(destination, value);
                }
            }
        }


        public static T Map<T>(object source) where T : new()
        {
            T ob = new();

            foreach (var item in source.GetType().GetProperties())
            {
                var destininationPropety = ob.GetType().GetProperty(item.Name);
                if (destininationPropety != null)
                {
                    var value = item.GetValue(source);
                    destininationPropety.SetValue(ob, value);
                }
            }

            return ob;
        }

        public static void ToString(object obj)
        {
            foreach (var item in obj.GetType().GetProperties())
            {
                Console.WriteLine($"{item.Name} : {item.GetValue(obj)}");
            }
        }
    }
} 
