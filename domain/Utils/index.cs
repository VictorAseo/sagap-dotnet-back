namespace domain.Utils;

public static class Utils
{
    public static string GetEnumDescription(this Enum genericEnum)
    {

        Type genericEnumType = genericEnum.GetType();
        System.Reflection.MemberInfo[] memberInfo =
            genericEnumType.GetMember(genericEnum.ToString());

        if ((memberInfo != null && memberInfo.Length > 0))
        {

            dynamic _Attribs = memberInfo[0].GetCustomAttributes
                (typeof(System.ComponentModel.DescriptionAttribute), false);
            if ((_Attribs != null && _Attribs.Length > 0))
            {
                return ((System.ComponentModel.DescriptionAttribute)_Attribs[0]).Description;
            }
        }

        return genericEnum.ToString();
    }
}
