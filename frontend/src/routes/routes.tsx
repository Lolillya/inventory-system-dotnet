import { createBrowserRouter, Navigate } from "react-router-dom";
import LoginPage from "../pages/login";
import DashboardPage from "../pages/admin/dashboard";
import MainLayout from "../layouts/main-layout";
import DefaultLayout from "../layouts/default-layout";
import SuppliersPage from "../pages/admin/suppliers";
import CustomersPage from "../pages/admin/customers";
import InventoryPage from "../pages/admin/inventory";
import EmployeesPage from "../pages/admin/employees";

export const router = createBrowserRouter([
  {
    element: <DefaultLayout />,
    children: [
      {
        index: true,
        element: <Navigate to="/login" replace />,
      },
      {
        path: "login",
        element: <LoginPage />,
      },
    ],
  },
  {
    element: <MainLayout />,
    children: [
      {
        path: "admin/",
        children: [
          {
            path: "dashboard",
            element: <DashboardPage />,
          },
          {
            path: "suppliers",
            element: <SuppliersPage />,
          },
          {
            path: "customers",
            element: <CustomersPage />,
          },
          {
            path: "inventory",
            element: <InventoryPage />,
          },
          {
            path: "employees",
            element: <EmployeesPage />,
          },
        ],
      },
    ],
  },
]);
