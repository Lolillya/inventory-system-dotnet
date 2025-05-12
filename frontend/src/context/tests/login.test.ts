import { loginAPI } from "../../services/auth-service/auth-login.service";

describe("Login API Testing", () => {
  it("should return 200 for /api/auth/login API endpoint", async () => {
    const username = "admin1";
    const password = "P@ssword_000";

    const res = await loginAPI(username, password);

    console.log(res); // Log the actual response

    // Assert response status and data
    expect(res!.status).toBe(200);
    expect(res!.data).toHaveProperty("username");
    expect(res!.data).toHaveProperty("email");
  });
});
