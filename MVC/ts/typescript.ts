interface TestRenamed {
    name: string;
    id: number;
}

const user: TestRenamed = ({
    username: "Hayes",
    id: 0,
}) as any;