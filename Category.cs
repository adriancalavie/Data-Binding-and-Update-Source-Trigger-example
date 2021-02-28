namespace DataBindingAndUpdateSourceTrigger
{
    public enum Category
    {
        SPORTS,
        HOME,
        ELECTRONICS,
        UNKNOWN
    }

    public static class CategoryExtension
    {
        public static string ToStringValue(this Category category)
        {
            string value = "unknown";
            switch (category)
            {
                case Category.SPORTS:
                    value = "Sports";
                    break;

                case Category.HOME:
                    value = "Home";
                    break;

                case Category.ELECTRONICS:
                    value = "Electronics";
                    break;
                default:
                    value = "Unknown";
                    break;
            }

            return value;
        }

        public static Category ToCategoryValue(this string value)
        {
            Category result = Category.UNKNOWN;

            value = value.ToLower();

            switch (value)
            {
                case "electronics":
                    result = Category.ELECTRONICS;
                    break;
                case "home":
                    result = Category.HOME;
                    break;
                case "sports":
                    result = Category.SPORTS;
                    break;
                case "unkonwn":
                default:
                    result = Category.UNKNOWN;
                    break;
            }

            return result;
        }
    }
}

