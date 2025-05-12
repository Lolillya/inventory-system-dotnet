import { useAuth } from "../../../context/use-auth";
import { useEffect } from "react";
import { useNavigate } from "react-router-dom";
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
    <div className="w-full flex justify-center items-center">
      <div>dashboard</div>
    </div>
  );
};

export default DashboardPage;
