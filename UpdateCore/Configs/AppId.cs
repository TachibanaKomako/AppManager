using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace UpdateCore.Configs
{
    public class AppId : IEquatable<AppId>
    {
        public AppId(int id)
        {
            Id = id;
        }
        public int Id { get; private init; }
        public bool Equals(AppId? other)
        {
            if(other == null)
            {
                return false;
            }
            else
            {
                return Id == other.Id;
            }
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as AppId);
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
        
    }
}
