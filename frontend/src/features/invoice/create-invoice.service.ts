import { handleError } from "@/helpers/error-handler.helper";
import { InvoiceProductModel } from "@/models/invoice.model";

export const createInvoice = async (
  payload: InvoiceProductModel[],
  customerId?: string | number,
  userId?: string | number
) => {
  console.log("customerId: ", customerId);
  console.log("userId: ", userId);
  console.log("payload: ", payload);

  try {
    const dtos = {
      LineItem: [{}],
      Invoice_Clerk: userId,
      Notes: "Sample Invoice Note",
    };
  } catch (e) {
    handleError(e);
  }
};
