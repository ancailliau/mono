namespace System.Net.Sockets {
    using System;
    
    public class MPTCPSubStatus {
        int id;
        int slave_sk;
        int fully_established;
        int attached;
        int low_prio;
        int pre_established;

        public MPTCPSubStatus(int id, int slave_sk, int fully_established, int attached, int pre_established) {
            SubCount = sub_count;
        }
        
        public int Id {
            get {
                return id;
            }
            set {
                id = value;
            }
        }

    } // class MPTCPSubStatus
} // namespace System.Net.Sockets
