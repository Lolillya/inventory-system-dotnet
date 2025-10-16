import { UserClientModel } from "@/models/user-client.model";
import { useQuery, useQueryClient } from "@tanstack/react-query";

const RestockSupplierKey = ["restock-supplier"];

export const useSelectedRestockSupplier = () => {
  return useQuery<UserClientModel>({
    queryKey: RestockSupplierKey,
    queryFn: async () => {
      return {
        id: "",
        username: "",
        email: "",
        firstName: "",
        lastName: "",
        companyName: "",
        notes: "",
        phoneNumber: "",
        role: "",
      };
    },
    enabled: false,
  });
};

export const updateSelectedSupplier = () => {
  const queryClient = useQueryClient();

  const UPDATE_SELECTED_SUPPLIER = (supplier: UserClientModel) => {
    queryClient.setQueryData(RestockSupplierKey, supplier);
  };

  return {
    UPDATE_SELECTED_SUPPLIER,
  };
};
