using System;
using System.Collections.Generic;

namespace AstraLearn.Models;

public partial class User
{
    public int IdPengguna { get; set; }

    public string Username { get; set; } = null!;

    public string NamaLengkap { get; set; } = null!;

    public string HakAkses { get; set; } = null!;
}
