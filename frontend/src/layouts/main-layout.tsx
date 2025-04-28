import { Outlet } from "react-router-dom";
import Sidebar from "../components/sidebar";
import ProtectedRoute from "../routes/protected-route";

const MainLayout = () => {
  return (
    <ProtectedRoute>
      <main>
        <Sidebar />
        <Outlet />
      </main>
    </ProtectedRoute>
  );
};

export default MainLayout;
