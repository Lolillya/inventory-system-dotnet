import { useQuery, useQueryClient } from "@tanstack/react-query";
import { SupplierModel } from "../../models/supplier.model";

const supplierSelectedKey = ["supplier-selected"];

export const useSupplierSelectedQuery = () => {
  return useQuery<SupplierModel>({
    queryKey: supplierSelectedKey,
    queryFn: async () => {
      return null as unknown as SupplierModel;
    },
    enabled: false,
  });
};

export const useSetSupplierSelected = () => {
  const queryClient = useQueryClient();

  return (supplier: SupplierModel) => {
    queryClient.setQueryData<SupplierModel>(supplierSelectedKey, supplier);
  };
};
