import { useQuery, useQueryClient } from "@tanstack/react-query";
import { UserClientModel } from "../../models/user-client.model";

const customerSelectedKey = ["customer-selected"];

export const useSelectedCustomerQuery = () => {
  return useQuery<UserClientModel>({
    queryKey: customerSelectedKey,
    queryFn: async () => {
      return null as unknown as UserClientModel;
    },
    enabled: false,
  });
};

export const useSetCustomerSelected = () => {
  const queryClient = useQueryClient();

  const UPDATE_SELECTED_CUSTOMER = (customer: UserClientModel) => {
    queryClient.setQueryData(customerSelectedKey, customer);
  };

  return {
    UPDATE_SELECTED_CUSTOMER,
  };
};
