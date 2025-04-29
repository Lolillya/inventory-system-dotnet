import { useQuery } from "@tanstack/react-query";
import { GetAllSuppliers } from "../../services/suppliers/get-all-suppliers.service";
import { SupplierModel } from "../../models/user-client.model";

export const useSuppliersQuery = () => {
  return useQuery<SupplierModel[]>({
    queryKey: ["suppliers"],
    queryFn: async () => {
      const response = await GetAllSuppliers();
      if (!response) throw new Error("Failed to fetch suppliers");
      return response.data;
    },
    staleTime: 60 * 1000,
  });
};
