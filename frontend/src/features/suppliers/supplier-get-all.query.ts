import { useQuery } from "@tanstack/react-query";
import { GetAllSuppliers } from "./get-all-suppliers.service";
import { UserClientModel } from "../../models/user-client.model";

export const useSuppliersQuery = () => {
  return useQuery<UserClientModel[]>({
    queryKey: ["suppliers"],
    queryFn: async () => {
      const response = await GetAllSuppliers();
      if (!response) throw new Error("Failed to fetch suppliers");
      return response.data;
    },
    staleTime: 60 * 1000,
  });
};
