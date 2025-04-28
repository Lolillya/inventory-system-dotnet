import React from "react";
import axios from "axios";
import { renderHook, act } from "@testing-library/react";
import { UserProvider, useAuth } from "../use-auth";

jest.mock("axios");

describe("loginUser", () => {
  afterEach(() => {
    jest.clearAllMocks();
    localStorage.clear();
  });

  test("should return user data on successful login", async () => {
    const mockResponse = {
      data: {
        UserName: "admin1",
        email: "admin1@example.com",
        token: "mock-token",
      },
    };

    (axios.post as jest.MockedFunction<typeof axios.post>).mockResolvedValue(
      mockResponse
    );

    const wrapper = ({ children }: { children: React.ReactNode }) => (
      <UserProvider>{children}</UserProvider>
    );

    const { result } = renderHook(() => useAuth(), { wrapper });

    let userData;
    await act(async () => {
      userData = await result.current.loginUser("admin1", "P@ssword_000");
    });

    expect(userData).toEqual({
      UserName: "admin1",
      email: "admin1@example.com",
    });

    expect(localStorage.getItem("token")).toBe("mock-token");
    expect(localStorage.getItem("user")).toBe(
      JSON.stringify({
        UserName: "admin1",
        email: "admin1@example.com",
      })
    );
  });
});
