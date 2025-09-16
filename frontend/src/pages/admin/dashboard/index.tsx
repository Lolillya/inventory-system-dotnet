import { useAuth } from "../../../context/use-auth";
import { useEffect } from "react";
import { useNavigate } from "react-router-dom";
import { StockedIn } from "./_components/stocked-in";
import { StockedOut } from "./_components/stocked-out";
import { SuppliersCard } from "./_components/suppliers-card";
import { CustomersCard } from "./_components/customers-card.";
import { BellIcon, HandshakeIcon } from "../../../icons";
// import { useSuppliersQuery } from "../../../services/suppliers/supplier-queries";

const DashboardPage = () => {
  // const { data: suppliers } = useSuppliersQuery();
  // console.log(suppliers);

  const { isLoggedIn, user } = useAuth();
  const navigate = useNavigate();

  useEffect(() => {
    if (!isLoggedIn()) {
      navigate("/");
    }
  }, [isLoggedIn, navigate, user]);

  if (!user) {
    return <div>Loading...</div>;
  }

  return (
    <section>
      <div className="flex flex-col gap-5 flex-1">
        <div className="flex gap-5 justify-end">
          <div className="p-3 shadow-lg rounded-lg border">
            <BellIcon />
          </div>

          <button>export</button>
        </div>
        <div className="w-full flex justify-center items-center">
          {/* DASHBOARD HEADER CARD */}
          <div className="flex justify-between w-full gap-5">
            <StockedIn />
            <StockedOut />
            <SuppliersCard />
            <CustomersCard />
          </div>
        </div>

        <div className="flex gap-5 flex-1">
          {/* LEFT */}
          <div className="flex flex-col gap-5 flex-1">
            <div className="rounded-lg shadow-lg p-5 w-full border flex-1">
              <span>Sales per Category</span>
            </div>

            <div className="flex gap-5 flex-1">
              <div className="rounded-lg shadow-lg p-5 border flex-1">
                <span>Sales Details</span>
              </div>
            </div>
          </div>

          {/* RIGHT */}
          <div className="rounded-lg shadow-lg p-5 w-[30%] border">
            <div className="flex flex-col gap-1">
              <div className="flex gap-1">
                <span className="rounded-lg ">
                  <HandshakeIcon />
                </span>
                <span className="capitalize">top suppliers</span>
              </div>

              {/* SUPPLIER LIST */}
              <div className="flex gap-2 bg-gray-bg p-2 rounded-full">
                <span className="rounded-full bg-green-950 p-2 w-7 h-7 items-center justify-center flex text-white">
                  1
                </span>
                <span>Supplier</span>
              </div>
            </div>
          </div>
        </div>
      </div>
    </section>
  );
};

export default DashboardPage;
