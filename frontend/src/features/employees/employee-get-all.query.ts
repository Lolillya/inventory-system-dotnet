import { useQuery } from "@tanstack/react-query";
import { UserClientModel } from "../../models/user-client.model";
import { GetAllEmployees } from "./get-all-employees.service";

export const userEmployeesQuery = () => {
  return useQuery<UserClientModel[]>({
    queryKey: ["employee"],
    queryFn: async () => {
      const response = await GetAllEmployees();
      if (!response) throw new Error("Failed to fetch employees");
      return response.data;
    },
    staleTime: 60 * 1000,
  });
};
