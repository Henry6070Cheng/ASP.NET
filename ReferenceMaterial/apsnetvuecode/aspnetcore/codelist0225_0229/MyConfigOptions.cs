using System.ComponentModel.DataAnnotations;

namespace codelist0225_0229;

public class MyConfigOptions
{
    [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$")]
    public string Key1 { get; set; }

    [Range(0, 100, ErrorMessage = "Value for {0} must be between {1} and {2}.")]
    public int Key2 { get; set; }
}
