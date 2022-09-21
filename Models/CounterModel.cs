using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models;
public class CounterModel
{
    public int Count { get; set; }
    public DateTime Created { get; set; }
    public string CreatedString { get => $"{Created:G}"; }
    public Guid Id { get; } = Guid.NewGuid();
}
