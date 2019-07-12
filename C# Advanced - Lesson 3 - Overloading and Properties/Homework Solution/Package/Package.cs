using System;
using System.Collections.Generic;
using System.Text;

namespace Package
{
    public class Package
    {
        private const int REGULAR_DELIVERY_FIRST_TWO_KILO = 20;
        private const int REGULAR_DELIVERY_ABOVE_TWO_KILO = 10;
        private const int EXPRESS_PER_KILO = 50;

        public enum EnumDeliveryType
        {
            Regular = 1,
            Express = 2
        }

        public enum EnumStatus
        {
            Primary = 1,
            Picked_up = 2,
            Delivered = 3
        }

        public int PackageID { get; private set; }
        public int FromCustomerID { get; private set; }
        public int ToCustomerID { get; private set; }
        public EnumStatus Status { get; private set; }
        private EnumDeliveryType DeliveryType { get; set; }
        private int Weight { get; set; }

        public Package(int packageId, int fromCustomerId, int toCustomerId, EnumDeliveryType deliveryType, int weight)
        {
            PackageID = packageId;
            FromCustomerID = fromCustomerId;
            ToCustomerID = toCustomerId;
            DeliveryType = deliveryType;
            Status = EnumStatus.Primary;
            Weight = weight;
        }

        public double CalcPrice()
        {
            double price = 0;
            int kilos = Weight / 1000 + (Weight % 1000 == 0 ? 0 : 1);

            if (DeliveryType == EnumDeliveryType.Regular)
            {
                if (kilos > 2)
                    price = REGULAR_DELIVERY_ABOVE_TWO_KILO * (kilos - 2) + (2 * REGULAR_DELIVERY_FIRST_TWO_KILO);
                else
                    price = kilos * REGULAR_DELIVERY_FIRST_TWO_KILO;
            }
            else if (DeliveryType == EnumDeliveryType.Express)
            {
                price = kilos * EXPRESS_PER_KILO;
            }

            return price;
        }

        public void Collected()
        {
            Status = EnumStatus.Picked_up;
        }

        public bool Delivered()
        {
            if (Status == EnumStatus.Picked_up)
            {
                Status = EnumStatus.Delivered;
                return true;
            }

            return false;
        }
    }
}


