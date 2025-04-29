import { useQuery, useQueryClient } from "@tanstack/react-query";
import { UserClientModel } from "../../models/user-client.model";

const employeeSelectedKey = ["employee-selected"];

export const useEmployeeSelectedQuery = () => {
  return useQuery<UserClientModel>({
    queryKey: employeeSelectedKey,
    queryFn: async () => {
      return null as unknown as UserClientModel;
    },
    enabled: false,
  });
};

export const useSetEmployeeSelected = () => {
  const queryClient = useQueryClient();

  return (employee: UserClientModel) => {
    queryClient.setQueryData<UserClientModel>(employeeSelectedKey, employee);
  };
};
