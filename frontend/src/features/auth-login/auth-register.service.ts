import axios from "axios";
import { handleError } from "../../helpers/error-handler.helper";
import { UserProfileToken } from "../../models/user.model";

const api = "http://localhost:5055/api";

export const registerAPI = async (
  email: string,
  username: string,
  password: string
) => {
  try {
    const data = await axios.post<UserProfileToken>(api + "account/register", {
      email: email,
      username: username,
      password: password,
    });
    return data;
  } catch (error) {
    handleError(error);
  }
};
