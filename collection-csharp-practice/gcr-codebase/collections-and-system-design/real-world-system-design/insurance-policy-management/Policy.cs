using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.collection_csharp_practice.gcr_codebase.collections_and_system_design.real_world_system_design.insurance_policy_management
{
    internal class Policy : IComparable<Policy>
    {
        public string PolicyNumber { get; set; }
        public string HolderName { get; set; }
        public string CoverageType { get; set; }
        public DateTime ExpiryDate { get; set; }

        public override bool Equals(object obj)
        {
            if (obj is Policy other)
                return PolicyNumber == other.PolicyNumber;
            return false;
        }

        public override int GetHashCode()
        {
            return PolicyNumber.GetHashCode();
        }

        public int CompareTo(Policy other)
        {
            int result = ExpiryDate.CompareTo(other.ExpiryDate);
            if (result == 0)
                return PolicyNumber.CompareTo(other.PolicyNumber);
            return result;
        }

    }
}

   