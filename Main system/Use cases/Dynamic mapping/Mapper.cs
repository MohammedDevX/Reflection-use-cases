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


        public static Type Map<T>(object source) where T : new()
        {
            var temp = typeof(T);

            T ob = new();

            foreach (var item in source.GetType().GetProperties())
            {
                var destininationPropety = temp.GetType().GetProperty(item.Name);
                if (destininationPropety != null)
                {
                    var value = item.GetValue(source);
                    destininationPropety.SetValue(ob, value);
                }
            }

            return temp;
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
