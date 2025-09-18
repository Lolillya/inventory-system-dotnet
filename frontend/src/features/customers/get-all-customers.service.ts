import axios from "axios";
import { api } from "../api/API.service";
import { handleError } from "../../helpers/error-handler.helper";
import { UserClientModel } from "../../models/user-client.model";

export const GetAllCustomers = async () => {
  try {
    const data = await axios.get<UserClientModel[]>(api + "users/?id=4");
    return data;
  } catch (err) {
    handleError(err);
  }
};
