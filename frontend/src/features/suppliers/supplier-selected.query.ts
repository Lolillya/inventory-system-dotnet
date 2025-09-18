import { useQuery, useQueryClient } from "@tanstack/react-query";
import { UserClientModel } from "../../models/user-client.model";

const supplierSelectedKey = ["supplier-selected"];

export const useSelectedSupplierQuery = () => {
  return useQuery<UserClientModel>({
    queryKey: supplierSelectedKey,
    queryFn: async () => {
      return null as unknown as UserClientModel;
    },
    enabled: false,
  });
};

export const useSetSupplierSelected = () => {
  const queryClient = useQueryClient();

  return (supplier: UserClientModel) => {
    queryClient.setQueryData<UserClientModel>(supplierSelectedKey, supplier);
  };
};
