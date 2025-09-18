import { useQuery } from "@tanstack/react-query";
import { UserClientModel } from "../../models/user-client.model";
import { GetAllCustomers } from "./get-all-customers.service";

export const useCustomersQuery = () => {
  return useQuery<UserClientModel[]>({
    queryKey: ["customer"],
    queryFn: async () => {
      const response = await GetAllCustomers();
      if (!response) throw new Error("Failed to fetch suppliers");
      return response.data;
    },
    staleTime: 60 * 1000,
  });
};
