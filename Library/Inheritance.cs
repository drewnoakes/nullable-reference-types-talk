#nullable enable

/// <summary>
/// 
///            ||||||||||||,,
///            |WWWWWWWWW|W|||,
///            |_________|~WWW||,
///             ~-_      ~_  ~WW||,
///             __-~---__/ ~_  ~WW|,
///         _-~~         ~~-_~_  ~W
///   _--~~~~~~~~~~___       ~-~_/
///  -                ~~~--_   ~_
/// |                       ~_   |
/// |   ____-------___        -_  |
/// |-~~              ~~--_     - |
///  ~| ~--___________     |-_   ~_
///    | \`o'/  \`o'_-~~  |  |~-_-
///   _-~_~~~    ~~~   _-~  |  |
///  ---.--__         ---.-~  |
///  | |    -~~-----~~| |    -
///  |_|__-~          |_|__-~
///  
/// </summary>
interface IRayGun
{
    string? Blast(string target);
}

class Blaster : IRayGun
{
    public string Blast(string? target) => "Kaboom";
}
