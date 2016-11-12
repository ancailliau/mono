namespace System.Net.Sockets {
    using System;
    
    public class MPTCPSubIds {
        int sub_count;

        public MPTCPSubIds(int sub_count) {
            SubCount = sub_count;
        }
        
        public int SubCount {
            get {
                return sub_count;
            }
            set {
                sub_count = value;
            }
        }

    } // class MPTCPSubIds
} // namespace System.Net.Sockets
